<%@ page language="java" import="java.util.List, Beans.ClassesBean" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
    <title>Enroll in Class</title>
</head>
<body>
    <h1>Enroll in a Class</h1>
    
    <!-- Display error message if it exists -->
    <%
        String errorMessage = request.getParameter("error");
        if (errorMessage != null) {
            out.println("<p style='color: red;'>" + errorMessage + "</p>");
        }
    %>

    <form action="enrollClass" method="post">
        <select name="courseId">
            <%
            List<ClassesBean> courses = (List<ClassesBean>) request.getAttribute("courses");
            if (courses != null && !courses.isEmpty()) {
                for (ClassesBean course : courses) {
            %>
                    <option value="<%= course.getCourseID() %>"><%= course.getTitle() %></option>
            <%
                }
            } else {
                out.println("No courses available.");
            }
            %>
        </select>
        <button type="submit">Enroll</button>
    </form>
</body>
</html>
