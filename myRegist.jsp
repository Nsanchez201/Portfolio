<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
    <title>Registration Details</title>
</head>
<body>
    <h1>Student Details</h1>
    <% 
        Beans.Student student = (Beans.Student) session.getAttribute("student");
        if (student != null) { 
    %>
        <p>Name: <%= student.getFname() %> <%= student.getLname() %></p>
        <p>Phone: <%= student.getPhone() %></p>
    <% 
        } 
    %>

    <h2>Enrolled Classes</h2>
    <% 
        java.util.List<Beans.EnrollBean> enrollments = (java.util.List<Beans.EnrollBean>) session.getAttribute("enrollments");
        if (enrollments != null && !enrollments.isEmpty()) { 
    %>
        <table border="1">
            <tr>
                <th>Course ID</th>
                <th>Title</th>
                <th>Grade</th>
                <th>Action</th>
            </tr>
            <% 
                for (Beans.EnrollBean enroll : enrollments) { 
            %>
                <tr>
                    <td><%= enroll.getCourseID() %></td>
                    <td><%= enroll.getTitle() %></td>
                    <td><%= enroll.getGrade() %></td>
                    <td>
                        <form action="dropClass" method="post">
                            <input type="hidden" name="courseId" value="<%= enroll.getCourseID() %>">
                            <button type="submit">Drop</button>
                        </form>
                    </td>
                </tr>
            <% 
                } 
            %>
        </table>
    <% 
        } else { 
    %>
        <p>No classes enrolled.</p>
    <% 
        } 
    %>
    <form action="registerClass" method="get">
        <button type="submit">Enroll in a New Class</button>
    </form>

    <form action="exitApp" method="post">
        <input type="submit" value="Exit" />
    </form>
</body>
</html>
