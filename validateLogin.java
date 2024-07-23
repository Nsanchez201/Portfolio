package FinalProject;

import javax.servlet.*;
import javax.servlet.http.*;


import javax.servlet.annotation.WebServlet;
import DBUtils.DButil;
import Beans.EnrollBean;
import Beans.Student;
import interfaces.IStudentService;
import interfaces.IEnrollmentService;
import java.io.IOException;
import java.util.List;

@WebServlet("/validateLogin")
public class validateLogin extends HttpServlet {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	    String ssn = request.getParameter("ssn").trim();
	    HttpSession session = request.getSession(true);
	    DButil dbUtil = new DButil();
	    dbUtil.connectDB(session);

	    IStudentService studentService = new StudentServiceImpl();
	    IEnrollmentService enrollmentService = new EnrollmentServiceImpl();

	    try {
	        if (studentService.isStudentEnrolled(ssn, session)) {
	            Student student = studentService.getStudentBySSN(ssn, session);
	            List<EnrollBean> enrollments = enrollmentService.getEnrollmentsBySSN(ssn, session);
	            if (student != null) {
	                request.setAttribute("student", student); // Pass as request attribute for forwarding
	                request.setAttribute("enrollments", enrollmentService.getEnrollmentsBySSN(ssn, session));
	                session.setAttribute("student", student);
	                session.setAttribute("enrollments", enrollments);
	                request.getRequestDispatcher("myRegist.jsp").forward(request, response);
	               
	            } else {
	                response.sendRedirect("loginError.jsp?error=No student found with provided SSN.");
	            }
	        } else {
	            response.sendRedirect("loginError.jsp?error=No enrollment found for SSN.");
	        }
	    } catch (Exception e) {
	        e.printStackTrace();
	        response.sendRedirect("loginError.jsp?error=Internal server error.");
	    }
	}
}