# Edge Detection - Nhận dạng đường biên dùng phương pháp Sobel cho ảnh mức xám (grayscale image).
import cv2
from PIL import Image #Thư viện xử lý ảnh Pillow
import numpy as np
import math

#Khai báo đường dẫn file hình .png
filehinh= r"lena.jpg"

#Đọc, hiển thị ảnh màu dùng thư viện CV
Hinhgoc_CV=cv2.imread(filehinh, cv2.IMREAD_COLOR)

cv2.imshow('Anh mau RGB goc ',Hinhgoc_CV)

def MP14(filehinh,nguong):
    #Đọc ảnh màu dùng thư viện PIL, để thực hiện các tác vụ xử lý và tính toán
    Hinhgoc_PIL = Image.open(filehinh)

    #Tạo ảnh có cùng kích thước và mode của Hinhgoc_PIL, chứa kết ảnh chuyển đổi
    Output_IMG = Image.new(Hinhgoc_PIL.mode,Hinhgoc_PIL.size)

    #lấy kích thước ảnh từ Hinhgoc_PIL
    w=Hinhgoc_PIL.size[0]
    h=Hinhgoc_PIL.size[1]

    # Tạo mặt nạ là 1 ma trận 2 chiểu, 3x3 để nhân tích chập
    Sy = np.array([[-1, -2, -1], [0, 0, 0], [1, 2, 1]]) # Ma trận Sobel theo phương y
    Sx = np.array([[-1, 0, 1], [-2, 0, 2], [-1, 0, 1]]) # Ma trận Sobel theo phương x

    # Dùng 2 vòng for quét, đọc hết tất cả các điểm ảnh(pixel) có trong ảnh
    # Do mặt nạ có kích thước 3x3 nên viền ảnh sau khi xử lý có độ dày 1 pixel
    for x in range(1,w-1):
        for y in range(1,h-1):
            # Tạo ma trận rỗng có kích thước bằng mặt nạ cho từng kênh để chứa giá trị mức xám các pixel xung quanh vị trí (x,y)
            Arr_gray = np.array([[0, 0, 0], [0, 0, 0], [0, 0, 0]])

            # Quét, tính giá trị mức xám các pixel xung quanh vị trí x,y và gán vào ma trận Arr_gray
            for x_ in range(x-1, x+2):
                for y_ in range(y-1, y+2):

                    R, G, B = Hinhgoc_PIL.getpixel((x_, y_))                  #lấy giá trị màu tại điểm ảnh tại vị trí x_,y_

                    gray = np.uint8((0.2126 * R + 0.7152 * G + 0.0722 * B))  # Tính mức xám theo công thức luminance

                    Arr_gray[x_ - x + 1][y_ - y + 1] = gray                  # gán giá trị mức xám vào mãng

            Gx = sum(sum(Arr_gray*Sx))     # Tích chập Ma trận Sobel theo phương x   # Gradian theo phương x
            Gy = sum(sum(Arr_gray*Sy))     # Tích chập Ma trận Sobel theo phương y   # Gradian theo phương y
            Fx = abs(Gx)+abs(Gy)                # tính biên độ, của vector gradient(f) theo công thức 10.2-20.

            # Nếu Fx <= nguong thì f(x, y) là thuộc background, ngược lại thì f(x, y) là thuộc edge
            if Fx > nguong:
                Output_IMG.putpixel((x, y), (255, 255, 255)) # Edge
            else:
                Output_IMG.putpixel((x, y), (0, 0, 0)) # Background
    return Output_IMG

# Dùng hàm, Chuyển đổi ảnh PIL sang CV và hiển thị
img=MP14(filehinh,100)
img=np.array(img)
cv2.imshow('MP14 Image',img)

# Hàm đóng cửa số và giải phóng bộ nhớ
cv2.waitKey(0)
cv2.destroyAllWindows()






