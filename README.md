# Test-C-

#ข้อ 1
 
Code: 

           public Index() {
             List<int> yearList = new List<int>();
              int startYear = 2500 - 543;
              int endYear = 2600 - 543;
              for (int year = startYear; year < endYear; year++)
              {
                  DateTime dd = new DateTime(year, 1, 1);
                  if ((int)dd.DayOfWeek == 6)
                  {
                      yearList.Add(year+543);

                  }
              }

              ViewBag.year = yearList;
              return View();
            }


#ออกแบบ SQL
![Image](https://www.img.in.th/images/5a9748b10cf7357a4a507eb6656855d9.png)

Format: ![Alt text](url)

 
#ข้อ 2 เขียน SQL
* -	จงหาจำนวนคนในแต่ละแผนก
SELECT Department.name,Count(Employ.employeeId) 
FROM Employee, Department
WHERE Department.departmentId = Employee.departmentId                                                                                  
GROUP BY Department.name;


* -	จงหาข้อมูลพนักงานทุกคนเรียงตามแผนก ถ้าคนที่ไม่มีแผนกให่แสดงข้อความว่า “ไม่มีแผนก” คอลัมน์ชื่อแผนก
SELECT Employee.firstname,  Employee.lastname,                                                                                                                 CASE Department.name WHEN isnull THEN ‘ไม่มีแผนก’ ELSE Department.name END                                                                                 FROM Employee , Department                                                                                                                                        WHERE Employee.departmentId = Department.departmentId;

* -	จงหาหัวหน้าแผนกแต่ละแผนก
SELECT Employee.firstname, Employee.lastname, Department.name, Position.name                                                         
FROM Department, Employee, Position                                                                                                                                   WHERE Employee.departmentId = Department.departmentId AND Employee.employeeId = Position.employeeId AND Position.name = 'head ';

* -	หาหัวหน้าแผนก ของแผนกแต่ละแผนกที่จำนวนคนมากที่สุด
SELECT TOP 1 Employee.firstname,Position.name, Department.name,COUNT(Employee.mmployeeId) AS result              
FROM Employee , Department , Position                                                                                                                        WHERE Department.departmentId = Employee.departmentID                                                                                                                                    AND  Employee.employeeId = Position.employeeId                                                                                                                                                                                        AND Position.name = 'head'                                                                                                                                                            GROUP BY Employee.name , Department.name , Position.name                                                                                                                        ORDER BY result DESC;


