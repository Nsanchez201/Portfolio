package FinalProject;

import interfaces.ICourseService;
import Beans.ClassesBean;
import DBUtils.DButil;
import java.util.ArrayList;
import java.util.List;
import javax.servlet.http.HttpSession;
import java.sql.ResultSet;
import java.sql.SQLException;

public class CourseServiceImpl implements ICourseService {
    private DButil dbUtil = new DButil();

    @Override
    public List<ClassesBean> getAllCourses(HttpSession session) {
        List<ClassesBean> courses = new ArrayList<>();
        ResultSet rs = null;
        try {
            rs = dbUtil.getAllCourses(session);
            while (rs.next()) {
                String courseID = rs.getString("courseID");
                String title = rs.getString("title");
                courses.add(new ClassesBean(courseID, title));
            }
        } catch (SQLException e) {
            e.printStackTrace();
            // Handle exception appropriately
        } finally {
            try {
                if (rs != null) {
                    rs.close();
                }
            } catch (SQLException e) {
                e.printStackTrace();
            }
        }
        return courses;
    }
}
