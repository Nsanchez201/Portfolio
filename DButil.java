package DBUtils;

import java.sql.*;
import javax.servlet.http.HttpSession;
import Beans.Student;
import Beans.EnrollBean;
import java.util.ArrayList;
import java.util.List;
import java.time.LocalDate;

public class DButil {
    private String connectionUrl = "jdbc:mysql://database-cuny.c4piq2ndsfvh.us-west-1.rds.amazonaws.com:3306/CUNY_DB";
    private String driver = "com.mysql.cj.jdbc.Driver";  

    // Establishes connection if it does not exist in the session
    public void connectDB(HttpSession session) {
        Connection connection = (Connection) session.getAttribute("dbConnection");
        if (connection == null) {
            try {
                Class.forName(driver);
                connection = DriverManager.getConnection(connectionUrl, "cst4713", "password1"); // Example credentials
                session.setAttribute("dbConnection", connection);
                System.out.println("Database connection established.");
            } catch (Exception ex) {
                System.out.println("Failed to connect to database: " + ex.getMessage());
                ex.printStackTrace();
            }
        }
    }

    // Get the connection from session
    public Connection getConnection(HttpSession session) {
        return (Connection) session.getAttribute("dbConnection");
    }

    // Closes the database connection and removes it from the session
    public void closeConn(HttpSession session) {
        Connection connection = getConnection(session);
        if (connection != null) {
            try {
                connection.close();
                session.removeAttribute("dbConnection");
                System.out.println("Database connection closed.");
            } catch (SQLException e) {
                System.out.println("Failed to close database connection: " + e.getMessage());
                e.printStackTrace();
            }
        }
    }

    // Check if an SSN is enrolled in any courses
    public boolean isSSNEnrolled(String ssn, HttpSession session) {
        connectDB(session); // Ensure connection is active
        Connection connection = getConnection(session);
        try {
            String query = "SELECT 1 FROM Students WHERE ssn = ?";
            PreparedStatement pstmt = connection.prepareStatement(query);
            pstmt.setString(1, ssn);
            ResultSet rs = pstmt.executeQuery();
            boolean exists = rs.next();
            rs.close();
            pstmt.close();
            return exists;
        } catch (SQLException ex) {
            System.out.println("SQL Exception in isSSNEnrolled: " + ex.getMessage());
            ex.printStackTrace();
            return false;
        }
    }

    // Fetch student details by SSN
    public Student getStudentDetails(String ssn, HttpSession session) {
        connectDB(session);
        Connection connection = getConnection(session);
        try {
            String query = "SELECT * FROM Students WHERE ssn = ?";
            PreparedStatement pstmt = connection.prepareStatement(query);
            pstmt.setString(1, ssn);
            ResultSet rs = pstmt.executeQuery();
            if (rs.next()) {
                Student student = new Student(
                    rs.getString("ssn"),
                    rs.getString("firstName"),
                    rs.getString("mi"),
                    rs.getString("lastName"),
                    rs.getString("birthDate"),
                    rs.getString("street"),
                    rs.getString("phone"),
                    rs.getString("zipcode"),
                    rs.getString("deptId")
                );
                rs.close();
                pstmt.close();
                return student;
            }
        } catch (SQLException ex) {
            System.out.println("SQL Exception in getStudentDetails: " + ex.getMessage());
            ex.printStackTrace();
        } 
        return null;
    }

    // Retrieve a list of EnrollBeans for a given SSN
    public List<EnrollBean> getEnrollmentsBySSN(String ssn, HttpSession session) {
        List<EnrollBean> enrollments = new ArrayList<>();
        connectDB(session);
        Connection connection = getConnection(session);
        try {
            String query = "SELECT Enrollment.courseID, Course.title, Enrollment.grade FROM Enrollment JOIN Course ON Enrollment.courseID = Course.courseID WHERE Enrollment.ssn = ?";
            PreparedStatement pstmt = connection.prepareStatement(query);
            pstmt.setString(1, ssn);
            ResultSet rs = pstmt.executeQuery();
            while (rs.next()) {
                EnrollBean enrollBean = new EnrollBean(
                    rs.getString("courseID"),
                    rs.getString("title"),
                    rs.getString("grade")
                );
                enrollments.add(enrollBean);
            }
            rs.close();
            pstmt.close();
            return enrollments;
        } catch (SQLException e) {
            System.out.println("SQL Exception in getEnrollmentsBySSN: " + e.getMessage());
            e.printStackTrace();
            return null;
        }
    }

    // Display courses
    public ResultSet getAllCourses(HttpSession session) throws SQLException {
        Connection connection = (Connection) session.getAttribute("dbConnection");
        if (connection == null) {
            // Ensure connection is established if it's not already in session
            connectDB(session);
            connection = (Connection) session.getAttribute("dbConnection");
        }
        String query = "SELECT courseID, title FROM Course";
        PreparedStatement pstmt = connection.prepareStatement(query, ResultSet.TYPE_SCROLL_INSENSITIVE, ResultSet.CONCUR_READ_ONLY);
        return pstmt.executeQuery();
    }

    // Add courses
    public boolean addEnrollment(String ssn, String courseId, HttpSession session) {
        connectDB(session);
        Connection connection = getConnection(session);
        String query = "INSERT INTO Enrollment(ssn,courseID,dateRegistered,grade) VALUES (?, ?,'" + Date.valueOf(LocalDate.now()) + "','A')";
        try {
            PreparedStatement pstmt = connection.prepareStatement(query);
            pstmt.setString(1, ssn);
            pstmt.setString(2, courseId);
            int affectedRows = pstmt.executeUpdate();
            pstmt.close();
            return affectedRows > 0;
        } catch (SQLException e) {
            System.out.println("Error adding enrollment: " + e.getMessage());
            return false;
        } 
    }
    
    //Drop courses
    public boolean dropCourse(String ssn, String courseId, HttpSession session) {
        Connection connection = (Connection) session.getAttribute("dbConnection");
        try {
            String query = "DELETE FROM Enrollment WHERE ssn = ? AND courseId = ?";
            PreparedStatement pstmt = connection.prepareStatement(query);
            pstmt.setString(1, ssn);
            pstmt.setString(2, courseId);
            int affectedRows = pstmt.executeUpdate();
            pstmt.close();
            return affectedRows > 0;
        } catch (SQLException e) {
            e.printStackTrace();
            return false;
        }
    }

}
