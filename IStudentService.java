package interfaces;

import Beans.Student;
import javax.servlet.http.HttpSession;

public interface IStudentService {
    Student getStudentBySSN(String ssn, HttpSession session);
    boolean isStudentEnrolled(String ssn, HttpSession session);
}