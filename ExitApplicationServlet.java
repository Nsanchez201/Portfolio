package FinalProject;

import java.io.IOException;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.WebServlet;
import DBUtils.DButil;

@WebServlet("/exitApp")
public class ExitApplicationServlet extends HttpServlet {
    /**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        HttpSession session = request.getSession(false);
        if (session != null) {
            DButil dbUtil = new DButil();
            dbUtil.closeConn(session);
            session.invalidate(); // Invalidate the session
            response.sendRedirect("regisLogin.jsp");
        }
    }
}
