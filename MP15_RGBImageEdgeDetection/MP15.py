import cv2
from PIL import Image
import numpy as np

# Khai báo đường dẫn file hình
filehinh = r'lena.jpg'

# Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

# Đọc ảnh màu dùng thư viện PIL. Ảnh PIL này chúng ta sẽ dùng
# để thực hiện các tác vụ xử lý & tính toán thay vì dùng OpenCV
imgPIL = Image.open(filehinh)

# Tạo một ảnh có cùng kích thước và cùng mode với ảnh PIL 
# Ảnh này dùng để chứa kết quả chuyển đổi RGB sang Grayscale
SobelImg = Image.new(imgPIL.mode,imgPIL.size)

#Ma trận thay thế để tính thay cho phương pháp laplician
matran = np.array([[0,-1,0],[-1,4,-1],[0,-1,0]])

# Lấy kích thước ảnh
width = imgPIL.size[0]
height = imgPIL.size[1]

# Chọn ngưỡng so sánh 
level = 130
# Dùng ma trận Sobel để nhận dạng đường biên
Sx = np.array([[-1,-2,-1],[0,0,-0],[1,2,1]])
Sy = np.array([[-1,0,1],[-2,0,2],[-1,0,1]])

# Sử dụng vòng lặp for để quét các điểm ảnh có trong hình
for x in range(1, width-1):
    for y in range(1, height-1):
        gxx = gyy = gxy = gxR = gxG = gxB = gyR = gyG = gyB = 0
        for i in range(x - 1, x + 2):
            for j in range(y - 1, y + 2):
                gR, gG, gB = imgPIL.getpixel((i, j))
                gxR +=gR*Sx[i-x+1,j-y+1]
                gxR +=gR*Sy[i-x+1,j-y+1]
                gxG +=gG*Sx[i-x+1,j-y+1]
                gxG +=gG*Sy[i-x+1,j-y+1]
                gxB +=gB*Sx[i-x+1,j-y+1]
                gxB +=gB*Sy[i-x+1,j-y+1]
        # Áp dụng công thức 6.7-5 đến 6.6-7 để tính các giá trị gxx, gxy, gyy 
        gxx = np.abs(gxR)**2 + np.abs(gxG)**2 + np.abs(gxB)**2
        gyy = np.abs(gyR)**2 + np.abs(gyG)**2 + np.abs(gyB)**2
        gxy = (gxR*gyR) + (gxG*gxG) + (gxB*gyB)
        # Tính góc Theta 
        theta = 0.5*np.arctan2((2*gxy),(gxx-gxy))
        # Áp dụng công thức 6.7-9 để tính giá trị F0(x,y)
        F0 = np.sqrt(0.5*((gxx+gxy)+(gxx-gyy)*np.cos(2*theta)+2*gxy*np.sin(2*theta)))
        # So sánh F0 với ngưỡng để xác định điểm Edge hay nền Background
        if F0 < level:
            SobelImg.putpixel((x,y),(0,0,0))
        else:
            SobelImg.putpixel((x,y),(255,255,255))

# Chuyển từ ảnh PIL sang OpenCV để hiển thị
AnhSobel = np.array(SobelImg)

# Hiển thị hình dùng thư viện OpenCV
cv2.imshow('Anh mau RGB goc',img)
cv2.imshow('Anh nhan dang bien dung Sobel',AnhSobel)

# Bấm phím bất kỳ để đóng cửa sổ hiển thị ảnh
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ
cv2.destroyAllWindows()

