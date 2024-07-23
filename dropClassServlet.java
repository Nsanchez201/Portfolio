package FinalProject;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.WebServlet;
import DBUtils.DButil;
import interfaces.IEnrollmentService;
import Beans.Student;
import java.io.IOException;

@WebServlet("/dropClass")
public class dropClassServlet extends HttpServlet {
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

        // Assuming there's a method in DButil to handle dropping a course
        if (dbUtil.dropCourse(student.getSsn(), courseId, session)) {
            // If drop successful, refresh enrollment list
            IEnrollmentService enrollmentService = new EnrollmentServiceImpl();
            session.setAttribute("enrollments", enrollmentService.getEnrollmentsBySSN(student.getSsn(), session));
            response.sendRedirect("myRegist.jsp");
        } else {
            response.sendRedirect("enrollDropError.jsp");
        }
    }
}
