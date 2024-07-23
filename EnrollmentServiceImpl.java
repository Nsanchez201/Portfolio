package FinalProject;

import interfaces.IEnrollmentService;
import DBUtils.DButil;
import Beans.EnrollBean;
import java.util.List;
import javax.servlet.http.HttpSession;

public class EnrollmentServiceImpl implements IEnrollmentService {
    private DButil dbUtil = new DButil();

    @Override
    public List<EnrollBean> getEnrollmentsBySSN(String ssn, HttpSession session) {
        return dbUtil.getEnrollmentsBySSN(ssn, session);
    }
}
