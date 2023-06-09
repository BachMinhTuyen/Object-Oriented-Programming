# :warning: Lập Trình Hướng Đối Tượng (Object-oriented Programming - OOP) :100:

### :construction:***Chú ý: Chỉ được phép dùng để tham khảo - :warning: Only allowed for reference*** :warning:

:triangular_flag_on_post: Chương trình khởi tạo ban đầu ([Start]()) :heavy_check_mark:

**:bookmark: >>>>>>>>>>>>>> MỤC LỤC <<<<<<<<<<<<<<<:bookmark:**

:point_right: **Lớp - Đối Tượng** ([Class & Object](#ClassAndObject)):fire:

:point_right: **Lớp Trừu Tượng** ([Abstract Class](#AbstractClass)):fire:

:point_right: **Kế Thừa và Đa Hình** ([Inheritance & Polymorphism](#Inheritance-Polymorphism)):fire:

:point_right: **Ôn tập** ([Review](#Review)):fire:

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
|![Xây dựng lớp kho sản phẩm](/Chapter_Classes%20And%20Objects/Image/KhoSanPham.png)|[Xây dựng lớp kho sản phẩm - Product_Warehouse_Exercise <br> **(Click here!)**](https://github.com/BachMinhTuyen/Object-Oriented-Programming/tree/main/Chapter_Classes%20And%20Objects/Product_Warehouse_Exercise)|
---

<a name="AbstractClass"></a>
## :pushpin: **Lớp Trừu Tượng ([Abstract Class](https://github.com/BachMinhTuyen/Object-Oriented-Programming/tree/main/Chapter_Abstract_Class))** :sparkles: 

:loudspeaker: Symbol (ký hiệu): ***abstract***
:loudspeaker: **Describe (mô tả):** 
- Là một lớp mà ***không thể tạo ra các đối tượng (instances) trực tiếp*** từ lớp đó. 
- Lớp trừu tượng thường được sử dụng để ***định nghĩa các phương thức*** mà các ***lớp con kế thừa phải triển khai*** (implement) theo cách riêng của chúng **(override)**.
- Lớp trừu tượng tuy không thể được khởi tạo trực tiếp, nhưng nó có thể **được sử dụng** như một kiểu dữ liệu để khai báo tham số, biến hoặc kiểu trả về phương thức.

1. :triangular_flag_on_post: Lớp trừu tượng **về hình học** (tính chu vi, diện tích) ([Geometry Abstract Class (Calculate Perimeter, Area)](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Abstract_Class/LopTruuTuong_HinhHoc.cs)) :heavy_check_mark:

2. :triangular_flag_on_post: Lớp trừu tượng **về môn học** (tính điểm lý thuyết, thực hành, đồ án) ([Subject Abstract Class (Theory, Practice, Project)](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Abstract_Class/LopTruuTuong_MonHoc.cs)) :heavy_check_mark:

3. :triangular_flag_on_post: Lớp trừu tượng **về phòng trọ** ([Abstract Class About Apartment](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Abstract_Class/LopTruuTuong_PhongTro.cs)) :heavy_check_mark:

| :file_folder: **Bài tập**  | (Exercise) :sparkles: |
| ----------- | ----------- |
|Coming Soon|Coming Soon|
---

<a name="Inheritance-Polymorphism"></a>
## :pushpin: **Kế Thừa và Đa Hình ([Inheritance & Polymorphism](https://github.com/BachMinhTuyen/Object-Oriented-Programming/tree/main/Chapter_Inheritance_Polymorphism))** :sparkles: 

:loudspeaker: **Describe (mô tả):** 
- **Kế thừa** là quá trình một lớp mới được tạo ra bằng cách **sử dụng lại** các *thuộc tính và phương thức từ một lớp đã tồn tại* gọi là lớp cha hoặc lớp cơ sở. 
- Lớp con được **kế thừa** các thuộc tính và phương thức của lớp cha và ***có thể mở rộng, thay đổi hoặc thêm mới các thuộc tính và phương thức riêng.***
- Kế thừa giúp tăng tính ***tái sử dụng mã nguồn, giảm thiểu việc lặp lại*** và *xây dựng các lớp có cấu trúc phân cấp.*
---
-  **Đa hình** là khả năng một đối tượng có thể **thể hiện** các ***hình dạng hoặc hành vi khác nhau*** dựa trên kiểu dữ liệu của nó hoặc lớp mà nó thuộc về. 
-  Đa hình cho phép chúng ta **sử dụng một giao diện chung** để *thao tác* với ***các đối tượng khác nhau*** trong cùng một tập hợp lớp. **(virtual - override)**
-  Nó cho phép chúng ta ***tối ưu hóa*** việc sử dụng mã nguồn và linh hoạt trong việc thay đổi hành vi của đối tượng tại **thời điểm chạy**.


1. :triangular_flag_on_post: Kế thừa | **Công ty bán cà phê** ([Inherit | Coffee trading company](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Inheritance_Polymorphism/KeThua_CongTyBanCaPhe.cs)) :heavy_check_mark:

2. :triangular_flag_on_post: Đa kế thừa - Interface | Ví dụ về **lớp động vật** ([Multi Inherit - Interface | Animal class example](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Inheritance_Polymorphism/DaKeThua_Interface_Animal.cs)) :heavy_check_mark:

3. :triangular_flag_on_post: Đa kế thừa - Interface | Ví dụ về **lớp chi tiết trao đổi hàng hoá** ([Multi Inherit - Interface | Commodity exchange detail class example](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Inheritance_Polymorphism/DaKeThua_Interface_ChiTietTraoDoiSanPham.cs)) :heavy_check_mark:

4. :triangular_flag_on_post: Đa kế thừa - Interface | Ví dụ về **lớp nhân viên**  ([Multi Inherit - Interface | Example of employee class](https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Chapter_Inheritance_Polymorphism/DaKeThua_Interface_NhanVien.cs)) :heavy_check_mark:

| :file_folder: **Bài tập**  | (Exercise) :sparkles: |
| ----------- | ----------- |
|![Xây dựng lớp bất động sản](/Chapter_Inheritance_Polymorphism/Image/Bai1_BatDongSan_Image.png)|[RealEstate_Exercise_Bai_8<br> **(Click here!)**](https://github.com/BachMinhTuyen/Object-Oriented-Programming/tree/main/Chapter_Inheritance_Polymorphism/RealEstate_Exercise)|
|Coming Soon|Coming Soon|
---

<a name="Review"></a>
## :pushpin: **Ôn Tập ([Review](https://github.com/BachMinhTuyen/Object-Oriented-Programming/tree/main/Review))** :sparkles: 

:loudspeaker: **Describe (mô tả):** Ôn tập lại toàn bộ những kiến thức về lập trình hướng đối tượng bao gồm các ***biến tĩnh***, ***phương thức khởi tạo***, ***phương thức nạp chồng (overload)***, ***kế thừa, đa hình (virtual - override)*** và ***interface.***

| :file_folder: **Ôn tập**  | (Review) :sparkles: |
| ----------- | ----------- |
|![Xây dựng quản lý thông tin sách](/Review/Image/Image_Book_Exercise.png)|[Book Information Management<br> **(Click here!)**](https://github.com/BachMinhTuyen/Object-Oriented-Programming/tree/main/Review/Book_Exercise)<hr>[Tải sơ đồ lớp - Diagram class download<br> **(Click here!)**](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/BachMinhTuyen/Object-Oriented-Programming/blob/main/Review/Book_Exercise/OnTap_Diagram.html)<br> *Tải xong -> vào thư mục lưu file vừa tải -> chuột phải vào file vừa tải chọn **"Extract Here"***|
---