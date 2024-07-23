package FinalProject;

import interfaces.IStudentService;
import DBUtils.DButil;
import Beans.Student;
import javax.servlet.http.HttpSession;

public class StudentServiceImpl implements IStudentService {
    private DButil dbUtil = new DButil();

    @Override
    public Student getStudentBySSN(String ssn, HttpSession session) {
        return dbUtil.getStudentDetails(ssn, session);
    }

    @Override
    public boolean isStudentEnrolled(String ssn, HttpSession session) {
        return dbUtil.isSSNEnrolled(ssn, session);
    }
}
