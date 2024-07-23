package FinalProject;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.WebServlet;
import interfaces.ICourseService;
import Beans.ClassesBean;
import java.io.IOException;
import java.util.List;

@WebServlet("/registerClass")
public class RegisterClassServlet extends HttpServlet {
    /**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        HttpSession session = request.getSession(false);
        if (session == null || session.getAttribute("student") == null) {
            response.sendRedirect("regislogin.jsp?error=Please log in first.");
            return;
        }

        ICourseService courseService = new CourseServiceImpl();
        List<ClassesBean> courses = courseService.getAllCourses(session);
        
        if (courses.isEmpty()) {
            request.setAttribute("message", "No courses available to enroll.");
        } else {
            request.setAttribute("courses", courses);
        }
        request.getRequestDispatcher("enroll.jsp").forward(request, response);
    }
}
