# :warning: Lập Trình Hướng Đối Tượng (Object-oriented Programming - OOP) :100:

### :construction:***Chú ý: Chỉ được phép dùng để tham khảo - :warning: Only allowed for reference*** :warning:

:triangular_flag_on_post: Chương trình khởi tạo ban đầu ([Start]()) :heavy_check_mark:

**:bookmark: >>>>>>>>>>>>>> MỤC LỤC <<<<<<<<<<<<<<<:bookmark:**

:point_right: **Lớp - Đối Tượng** ([Class & Object](#ClassAndObject)):fire:

:point_right: **Lớp Trừu Tượng** ([Abstract Class](#AbstractClass)):fire:

:point_right: **Kế Thừa và Đa Hình** ([Inheritance & Polymorphism](#Inheritance-Polymorphism)):fire:

---
:loudspeaker: **Tổng Quan - Overview**  :triangular_flag_on_post:

:wave: 1. Viết bằng ngôn ngữ **C# (C Sharp)**  :gift:

:wave: 2. Lập trình hướng đối tượng gồm có: **tính đóng gói, tính kế thừa, tính đa hình** :gift:

:rotating_light: **Lưu ý:** :rotating_light: Nếu đối với chạy chương trình trên **.NET 5 và phiên bản cũ hơn** thì dùng

:bulb: **Code [here !](https://learn.microsoft.com/en-us/dotnet/core/tutorials/top-level-templates)**

```
using System;
// Lưu ý: không gian tên thực phụ thuộc vào tên dự án.
// Note: actual namespace depends on the project name.
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

:bulb: Viết **Tiếng Việt** trong C# dùng lệnh

```
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.Unicode;
```

---
<a name="ClassAndObject"></a>
## :pushpin: **Lớp - Đối Tượng ([Class & Object](https://github.com/BachMinhTuyen/Object-Oriented-Programming/tree/main/Chapter_Classes%20And%20Objects))** :sparkles: 

:loudspeaker: **Describe (mô tả):** (Coming Soon)

1. :triangular_flag_on_post: Một số ví dụ về lớp - **Sắp có** ([Some Examples Of Classes - Coming Soon]()) :heavy_check_mark:

2. :triangular_flag_on_post: Tham số This - Nạp chồng phương thức - **Sắp có** ([Parameters 'This' - Overload Method - Coming Soon]()) :heavy_check_mark:

3. :triangular_flag_on_post: Biến tĩnh ([Static Var](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Classes%20And%20Objects/Static_Var.cs)) :heavy_check_mark:

4. :triangular_flag_on_post: Tạo danh sách sinh viên - sử dụng Generic ([Create List Of Student Using Generic](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Classes%20And%20Objects/List_Of_Student_Using_Generic.cs)) :heavy_check_mark:

| :file_folder: **Bài tập**  | (Exercise) :sparkles: |
| ----------- | ----------- |
|![Xây dựng lớp nhân viên](/Chapter_Classes%20And%20Objects/Image/Class_Object_Bai_2.png)|[NhanVien_Class_Exercise_Bai_2<br> **(Click here!)**](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Classes%20And%20Objects/NhanVien_Class_Exercise_Bai_2.cs)|
|![Xây dựng lớp nhân viên](/Chapter_Classes%20And%20Objects/Image/Class_Object_Bai_4.png)|[Xây dựng lớp nhân viên - Staff_Class_Exercise <br> **(Click here!)**](https://github.com/BachMinhTuyen/Object-Oriented-Programming/tree/main/Chapter_Classes%20And%20Objects/Staff_Class_Exercise)|
---

<a name="AbstractClass"></a>
## :pushpin: **Lớp Trừu Tượng ([Abstract Class](https://github.com/BachMinhTuyen/Object-Oriented-Programming/tree/main/Chapter_Abstract_Class))** :sparkles: 

:loudspeaker: **Describe (mô tả):** (Coming Soon)

1. :triangular_flag_on_post: Lớp trừu tượng **về hình học** (tính chu vi, diện tích) ([Geometry Abstract Class (Calculate Perimeter, Area)](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Abstract_Class/LopTruuTuong_HinhHoc.cs)) :heavy_check_mark:

2. :triangular_flag_on_post: Lớp trừu tượng **về môn học** (tính điểm lý thuyết, thực hành, đồ án) ([Subject Abstract Class (Theory, Practice, Project)](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Abstract_Class/LopTruuTuong_MonHoc.cs)) :heavy_check_mark:

3. :triangular_flag_on_post: Lớp trừu tượng **về phòng trọ** ([Abstract Class About Apartment](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Abstract_Class/LopTruuTuong_PhongTro.cs)) :heavy_check_mark:

| :file_folder: **Bài tập**  | (Exercise) :sparkles: |
| ----------- | ----------- |
|Coming Soon|Coming Soon|
---

<a name="Inheritance-Polymorphism"></a>
## :pushpin: **Kế Thừa và Đa Hình ([Inheritance & Polymorphism](https://github.com/BachMinhTuyen/Object-Oriented-Programming/tree/main/Chapter_Inheritance_Polymorphism))** :sparkles: 

:loudspeaker: **Describe (mô tả):** (Coming Soon)

1. :triangular_flag_on_post: Kế thừa | **Công ty bán cà phê** ([Inherit | Coffee trading company](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Inheritance_Polymorphism/KeThua_CongTyBanCaPhe.cs)) :heavy_check_mark:

2. :triangular_flag_on_post: Đa kế thừa - Interface | Ví dụ về **lớp động vật** ([Multi Inherit - Interface | Animal class example](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Inheritance_Polymorphism/DaKeThua_Interface_Animal.cs)) :heavy_check_mark:

3. :triangular_flag_on_post: Đa kế thừa - Interface | Ví dụ về **lớp chi tiết trao đổi hàng hoá** ([Multi Inherit - Interface | Commodity exchange detail class example](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Inheritance_Polymorphism/DaKeThua_Interface_ChiTietTraoDoiSanPham.cs)) :heavy_check_mark:

4. :triangular_flag_on_post: Đa kế thừa - Interface | Ví dụ về **lớp nhân viên**  ([Multi Inherit - Interface | Example of employee class](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Inheritance_Polymorphism/DaKeThua_Interface_NhanVien.cs)) :heavy_check_mark:

| :file_folder: **Bài tập**  | (Exercise) :sparkles: |
| ----------- | ----------- |
|Coming Soon|Coming Soon|
---