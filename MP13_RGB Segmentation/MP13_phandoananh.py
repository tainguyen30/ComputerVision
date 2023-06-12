import cv2
from PIL import Image
import numpy as np

# Khai báo đường dẫn file hình
filehinh = r'Lena.jpg'

# Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

# Đọc ảnh bằng PIL để thao tác tính toán
imgPIL = Image.open(filehinh)

# Tạo một ảnh có cùng kích thước và cùng mode với ảnh PIL 
SegImg = Image.new(imgPIL.mode, imgPIL.size)

# Lấy kích thước ảnh
width = imgPIL.size[0]
height = imgPIL.size[1]

X1 = 80
X2 = 150
Y1 = 400
Y2 = 500

Nguong = 45
    

Gs = 0
Rs = 0 
Bs = 0

# đọc các điểm ảnh có trong ảnh
for x in range(X1, X2):
    for y in range(Y1, Y2):
        # Lấy giá trị điểm ảnh tại vị trí (x, y)
        R, G, B = imgPIL.getpixel((x,y))

        # Cộng dồn điểm ảnh cho mỗi kênh tương ứng
        Rs += R
        Gs += G
        Bs += B

        size = np.abs(X2 - X1) * np.abs(Y2 - Y1)
Rs /= size
Gs /= size
Bs /= size



# Viết hàm phân đoạn ảnh
for x in range(width):
    for y in range(height):
        R1, G1, B1 = imgPIL.getpixel((x,y))

        # Áp dụng công thức tính Euclidean Distance giữa hai vector a và z 
        D = np.sqrt((R1 - Rs)**2 + (G1 - Gs)**2 + (B1 - Bs)**2)

        # Sau khi tính được giá trị D(z,a), chúng ta sẽ so sánh với giá trị ngưỡng (threshold) D
        # để xác định xem điểm z(x,y) đang xét là background hay object
        if (D > Nguong):
            SegImg.putpixel((x, y), (B1, G1, R1))
        else:
            SegImg.putpixel((x, y), (255, 255, 255))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
segimg = np.array(SegImg)   

# Hiển thị hình dùng thư viện OpenCV
cv2.imshow('Anh mau RGB goc', img)
cv2.imshow('Hinh phan doan mau', segimg)

# Bấm phím bất kỳ để đóng cửa sổ hiển thị ảnh
cv2.waitKey(0)
# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ
cv2.destroyAllWindows()