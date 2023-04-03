- Tạo user bằng cách thực thi những câu lệnh có trong file create_user_admin.sql trong thư mục ./Script/create_user_admin.sql vào Oracle Database của chính mình trước khi chạy chương trình.
- Chạy file App.sln, đăng nhập với - Username: U_AD, Password: 123.
- Ứng với mỗi nút chức năng sẽ có mỗi màn hình riêng biệt, ai được phân công phần nào thì chỉ cần làm trên màn hình đó. Tên màn hình có định dạng `f{Tên chức năng}`, ví dụ: `fUserList`, `fAddRole`, `fGrantRole`, ...
- Để thực thi câu lệnh mọi người gọi các lệnh sau (Instance trong lệnh chỉ là một cú pháp Singleton trong OOP): 
    + DataProvider.Instance.ExcuteQuery(query) $\to$ Chạy những lệnh có xuất ra dữ liệu 

    + DataProvider.Instance.ExcuteNonQuery(query) $\to$ Chạy những lệnh không xuất ra dữ liệu (Update, Insert, Delete, ...)

    + DataProvider.Instance.ExcuteScalar(query) $\to$ Xuất dòng dữ liệu đầu tiên, nếu kết quả lệnh có xuất ra dữ liệu
- Ảnh được đặt trong thư mục ./App/App/Images 
