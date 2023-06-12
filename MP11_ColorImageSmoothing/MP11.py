import cv2                          # Sử dụng thư viện xử lý ảnh Open CV 
from PIL import Image               # Thư viện xử lý ảnh PILLOW 
import numpy as np                  # Thư viện toán học Python
# Khai báo đường dẫn filehinh 
filehinh = r'LENA.jpg'
# Đọc ảnh màu dùng thư viện OpenCv 
img= cv2.imread(filehinh,cv2.IMREAD_COLOR)
# Đọc ảnh dùng thư viện PIL, ảnh PIL dùng thực hiện các tác vụ xử lý và tính toán thay vì dùng OpenCV
imgPIL = Image.open(filehinh)
#Tạo 1 ảnh có cùng mode và cùng size với ảnh PIL
Smoothed3  = Image.new(imgPIL.mode, imgPIL.size)       
Smoothed5  = Image.new(imgPIL.mode, imgPIL.size)       
Smoothed7  = Image.new(imgPIL.mode, imgPIL.size)
Smoothed9  = Image.new(imgPIL.mode, imgPIL.size)
# Kích thước ảnh 
width = imgPIL.size[0]  
height = imgPIL.size[1]

##################===3x3===##################
#Mỗi ma trận là một mảng hai chiều nên dùng 2 vòng lập for
#để quét hết các điểm ảnh có trong hình.
# Lưu ý với mặt nạ 3x3 để lập trình có thể bỏ qua các viền ngoài của ảnh
# Do vậy chỉnh cần quét từ vị trí x = 1, đến x = width - 1
# y = 1 đến y = Height - 1
for x in range(1,width-1):
    for y in range(1,height - 1):
        # Lấy giá trị điểm ảnh tại vị trí (x, y)
        # Biến này để chứa giá trị cộng dồn của các điểm ảnh trong mặt nạ

        Rs = 0
        Gs = 0
        Bs = 0

        #quét các điểm ảnh trong mặt nạ
        for i in range(x - 1, x + 2):
            for j in range(y - 1, y + 2):
        # Lấy thông tin màu R-G-B tại các điểm ảnh trong mặt nạ tại vị trí i,j
                R, G, B = imgPIL.getpixel((i, j))

#Cộng tất cả các điểm ảnh cho kênh R-G-B
                Rs += R
                Gs += G
                Bs += B
#Mình đi tính trung bình cộng cho mỗi kênh theo công thức 6.6-2 cho từng kênh màu
        K = 3 * 3
        Rs = np.uint8(Rs / K)
        Gs = np.uint8(Gs / K)
        Bs = np.uint8(Bs / K)

# Set điểm ảnh đã làm mượt vào hình
        Smoothed3.putpixel((x, y),(Bs, Gs, Rs))


##################===5x5===##################
#Mỗi ma trận là một mảng hai chiều nên dùng 2 vòng lập for
#để quét hết các điểm ảnh có trong hình.
# Lưu ý với mặt nạ 5x5 để lập trình có thể bỏ qua các viền ngoài của ảnh
# Do vậy chỉnh cần quét từ vị trí x = 2, đến x = width - 2
# y = 2 đến y = Height - 2     
for x in range(2,width - 2):
    for y in range(2,height - 2):
        # Lấy giá trị điểm ảnh tại vị trí (x, y)
        # Biến này để chứa giá trị cộng dồn của các điểm ảnh trong mặt nạ

        Rs = 0
        Gs = 0
        Bs = 0

        #quét các điểm ảnh trong mặt nạ
        for i in range(x - 2, x + 3):
            for j in range(y - 2, y + 3):
                    # Lấy thông tin màu R-G-B tại các điểm ảnh trong mặt nạ tại vị trí i,j
                R, G, B = imgPIL.getpixel((i, j))


#Cộng tất cả các điểm ảnh cho kênh R-G-B
                Rs += R
                Gs += G
                Bs += B
#Mình đi tính trung bình cộng cho mỗi kênh theo công thức 6.6-2 cho từng kênh màu
        K = 5 * 5
        Rs = np.uint8(Rs / K)
        Gs = np.uint8(Gs / K)
        Bs = np.uint8(Bs / K)

# Set điểm ảnh đã làm mượt vào hình
        Smoothed5.putpixel((x, y),(Bs, Gs, Rs))               


##################===7x7===##################
#Mỗi ma trận là một mảng hai chiều nên dùng 2 vòng lập for
#để quét hết các điểm ảnh có trong hình.
# Lưu ý với mặt nạ 7x7 để lập trình có thể bỏ qua các viền ngoài của ảnh
# Do vậy chỉnh cần quét từ vị trí x = 3, đến x = width - 3
# y = 3 đến y = Height - 3     
for x in range(3,width - 3):
    for y in range(3,height - 3):
        # Lấy giá trị điểm ảnh tại vị trí (x, y)
        # Biến này để chứa giá trị cộng dồn của các điểm ảnh trong mặt nạ
        Rs = 0
        Gs = 0
        Bs = 0

        #quét các điểm ảnh trong mặt nạ
        for i in range(x - 3, x + 4):
            for j in range(y - 3, y + 4):
        # Lấy thông tin màu R-G-B tại các điểm ảnh trong mặt nạ tại vị trí i,j
                R, G, B = imgPIL.getpixel((i, j))

#Cộng tất cả các điểm ảnh cho kênh R-G-B
                Rs += R
                Gs += G
                Bs += B
#Mình đi tính trung bình cộng cho mỗi kênh theo công thức 6.6-2 cho từng kênh màu
        K = 7 * 7
        Rs = np.uint8(Rs / K)
        Gs = np.uint8(Gs / K)
        Bs = np.uint8(Bs / K)

# Set điểm ảnh đã làm mượt vào hình
        Smoothed7.putpixel((x, y),(Bs, Gs, Rs))               

##################===9x9===##################
#Mỗi ma trận là một mảng hai chiều nên dùng 2 vòng lập for
#để quét hết các điểm ảnh có trong hình.
# Lưu ý với mặt nạ 9x9 để lập trình có thể bỏ qua các viền ngoài của ảnh
# Do vậy chỉnh cần quét từ vị trí x = 4, đến x = width - 4
# y = 4 đến y = Height - 4     
for x in range(4,width - 4):
    for y in range(4,height - 4):
        # Lấy giá trị điểm ảnh tại vị trí (x, y)
        # Biến này để chứa giá trị cộng dồn của các điểm ảnh trong mặt nạ

        Rs = 0
        Gs = 0
        Bs = 0

        #quét các điểm ảnh trong mặt nạ
        for i in range(x - 4, x + 5):
            for j in range(y - 4, y + 5):
            # Lấy thông tin màu R-G-B tại các điểm ảnh trong mặt nạ tại vị trí i,j
                R, G, B = imgPIL.getpixel((i, j))

#Cộng tất cả các điểm ảnh cho kênh R-G-B
                Rs += R
                Gs += G
                Bs += B
#Mình đi tính trung bình cộng cho mỗi kênh theo công thức 6.6-2 cho từng kênh màu
        K = 9 * 9
        Rs = np.uint8(Rs / K)
        Gs = np.uint8(Gs / K)
        Bs = np.uint8(Bs / K)

# Set điểm ảnh đã làm mượt vào hình
        Smoothed9.putpixel((x, y),(Bs, Gs, Rs))    

#Chuyển đổi ảnh từ ảnh PIL sang OpenCV để hiển thị:
anh3 = np.array(Smoothed3)
anh5 = np.array(Smoothed5)
anh7 = np.array(Smoothed7)
anh9 = np.array(Smoothed9)


#Hiển thị
cv2.imshow('Hinh mau goc RGB goc', img)
cv2.imshow('mask 3x3', anh3)
cv2.imshow('mask 5x5', anh5)
cv2.imshow('mask 7x7', anh7)
cv2.imshow('mask 9x9', anh9)

# Bấm phím bất kỳ để đóng
cv2.waitKey(0)

#Giải phóng bộ nhớ đã cấp phát
cv2.destroyAllWindows()

