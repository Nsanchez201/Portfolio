package interfaces;

import Beans.EnrollBean;
import java.util.List;
import javax.servlet.http.HttpSession;

public interface IEnrollmentService {
    List<EnrollBean> getEnrollmentsBySSN(String ssn, HttpSession session);
}
