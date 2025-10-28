// Java program to print current system date and time
// To compile: javac -source 8 -target 8 Run.java (ensure Java 8 compatibility with Windows Code flavor of App Service)
// To create a jar: jar cfe run.jar Run Run.class

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class Run {
    public static void main(String[] args) {
        System.out.println("Current system date and time:");
        LocalDateTime now = LocalDateTime.now();
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm:ss");
        System.out.println(now.format(formatter));
    }
}
