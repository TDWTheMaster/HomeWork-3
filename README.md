The `Community` application is an Object-Oriented Programming (OOP) system in C#. Its purpose is to manage information about different members of a community, allowing for addition, visualization, and classification of each member according to their specific role. Below, the design and functionality of the application are described.

Classes and Hierarchy

1. **CommunityMember**:
   - **Description**: This is the base class representing a general community member.
   - **Attributes**:
     - `Name`: The member's name.
     - `Identification`: The member's identification.
   - **Methods**:
     - `GetTypeDescription()`: Returns the type description of the member.
     - `ShowInformation()`: Displays the member's information.

2. **Employee**:
   - **Description**: Inherits from `CommunityMember` and represents an employee.
   - **Attributes**:
     - `Position`: The employee's position.
   - **Methods**:
     - `GetTypeDescription()`: Returns "Employee".
     - `ShowInformation()`: Displays the employee's information.

3. **Student**:
   - **Description**: Inherits from `CommunityMember` and represents a student.
   - **Attributes**:
     - `Major`: The student's major.
   - **Methods**:
     - `GetTypeDescription()`: Returns "Student".
     - `ShowInformation()`: Displays the student's information.

4. **Alumni**:
   - **Description**: Inherits from `CommunityMember` and represents a graduate.
   - **Attributes**:
     - `GraduationYear`: The year of graduation.
   - **Methods**:
     - `GetTypeDescription()`: Returns "Alumni".
     - `ShowInformation()`: Displays the graduate's information.

5. **Faculty**:
   - **Description**: Inherits from `Employee` and represents a faculty member.
   - **Attributes**:
     - `Department`: The faculty member's department.
   - **Methods**:
     - `GetTypeDescription()`: Returns "Faculty".
     - `ShowInformation()`: Displays the faculty member's information.

6. **Administrative**:
   - **Description**: Inherits from `Employee` and represents an administrative member.
   - **Attributes**:
     - `Area`: The administrative member's area.
   - **Methods**:
     - `GetTypeDescription()`: Returns "Administrative".
     - `ShowInformation()`: Displays the administrative member's information.

7. **Administrator**:
   - **Description**: Inherits from `Faculty` and represents an administrator.
   - **Attributes**:
     - `Level`: The administrator's level.
   - **Methods**:
     - `GetTypeDescription()`: Returns "Administrator".
     - `ShowInformation()`: Displays the administrator's information.

8. **Teacher**:
   - **Description**: Inherits from `Faculty` and represents a teacher.
   - **Attributes**:
     - `Subject`: The teacher's subject.
   - **Methods**:
     - `GetTypeDescription()`: Returns "Teacher".
     - `ShowInformation()`: Displays the teacher's information.

Program Functionality

The main program (`Program`) uses a list to store instances of `CommunityMember` and its derived classes. The user interacts with the program through a menu that allows the following actions:

1. **Add Administrator**: Prompts for specific data and creates an instance of `Administrator`.
2. **Add Teacher**: Prompts for specific data and creates an instance of `Teacher`.
3. **Add Faculty Member**: Prompts for specific data and creates an instance of `Faculty`.
4. **Add Administrative Staff**: Prompts for specific data and creates an instance of `Administrative`.
5. **Add Student**: Prompts for specific data and creates an instance of `Student`.
6. **Add Alumni**: Prompts for specific data and creates an instance of `Alumni`.
7. **Add Employee**: Prompts for specific data and creates an instance of `Employee`.
8. **View All Members**: Displays information about all community members.
9. **Exit**: Terminates the program.

Auxiliary Methods

The program also includes auxiliary methods to request user inputs and validate them:

- `RequestString(field)`: Requests a text string.
- `RequestNumber(field)`: Requests a string containing only numbers.
- `RequestInteger(field)`: Requests an integer number.

This modular and object-oriented design allows for easy extension and maintenance of the system, facilitating the management of different roles within a community.

RequestString(field): Requests a text string.
RequestNumber(field): Requests a string containing only numbers.
RequestInteger(field): Requests an integer number.
This modular and object-oriented design allows for easy extension and maintenance of the system, facilitating the management of different roles within a community.
