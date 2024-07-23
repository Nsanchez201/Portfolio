package FinalProject;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.WebServlet;
import DBUtils.DButil;
import Beans.Student;
import Beans.EnrollBean;
import interfaces.IEnrollmentService;
import java.io.IOException;
import java.util.List;

@WebServlet("/enrollClass")
public class EnrollClassServlet extends HttpServlet {
    /**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        HttpSession session = request.getSession();
        if (session == null || session.getAttribute("student") == null) {
            response.sendRedirect("regisLogin.jsp?error=Session expired or not logged in.");
            return;
        }

        Student student = (Student) session.getAttribute("student");
        String courseId = request.getParameter("courseId");
        DButil dbUtil = new DButil();
        IEnrollmentService enrollmentService = new EnrollmentServiceImpl();

        // Use the session-based database connection to perform operations
        if (dbUtil.addEnrollment(student.getSsn(), courseId, session)) {
            // Refresh the enrollments in session after successful enrollment
            List<EnrollBean> enrollments = enrollmentService.getEnrollmentsBySSN(student.getSsn(), session);
            session.setAttribute("enrollments", enrollments); // Update enrollments in session
            
            // Redirect with a success message
            response.sendRedirect("myRegist.jsp");
        } else {
            // Redirect with an error message if enrollment fails
            response.sendRedirect("enroll.jsp");
        
        }
    }
}
