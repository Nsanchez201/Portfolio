package interfaces;

import Beans.ClassesBean;
import java.util.List;
import javax.servlet.http.HttpSession;

public interface ICourseService {
    List<ClassesBean> getAllCourses(HttpSession session);
}
