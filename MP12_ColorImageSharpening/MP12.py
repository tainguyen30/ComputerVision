import cv2
from PIL import Image
import numpy as np

# Khai báo đường dẫn file hình
filehinh = r'Lena.jpg'

# Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

# Đọc ảnh màu dùng thư viện PIL. Ảnh PIL này chúng ta sẽ dùng
# để thực hiện các tác vụ xử lý & tính toán thay vì dùng OpenCV
imgPIL = Image.open(filehinh)

# Tạo một ảnh có cùng kích thước và cùng mode với ảnh PIL 
# Ảnh này dùng để chứa kết quả chuyển đổi RGB sang Grayscale
SharpImg = Image.new(imgPIL.mode,imgPIL.size)

#Ma trận thay thế để tính thay cho phương pháp laplician
matran = np.array([[0,-1,0],[-1,4,-1],[0,-1,0]])

# Lấy kích thước ảnh
width = imgPIL.size[0]
height = imgPIL.size[1]

# Mỗi ảnh là một ma trận 2 chiều nên sẽ dùng 2 vòng for để 
# đọc hết các điểm ảnh (pixel) có trong ảnh
for x in range(1, width-1):
    for y in range(1, height-1):
        #Lấy giá trị điểm ảnh tại (x, y). Các biến này chứa các giá trị cộng dồn 
        #của các điểm ảnh nằm trong mặt nạ
        Rs = 0
        Gs = 0
        Bs = 0
        #Quét các điểm trong mặt nạ
        for i in range(x - 1, x + 2):
            for j in range(y - 1, y + 2):
                #Lấy thông tin màu RGB tại điểm ảnh trong mặt nạ tại vị trí (i, j)
                    R, G, B = imgPIL.getpixel((i,j))
                #Nhân tích chập cho tất cả các điểm ảnh của mỗi kênh R-G-B
                    Rs+= R*matran[i-x+1,j-y+1]
                    Gs+= G*matran[i-x+1,j-y+1]
                    Bs+= B*matran[i-x+1,j-y+1]
        #Kết thúc quét và cộng dồn điểm ảnh trong mặt nạ
        #thì tính điểm sắc nét ảnh mỗi kênh theo công thức 3.6-7
        R1, G1, B1 = imgPIL.getpixel((x, y))
        SharpR = R1 + Rs
        SharpG = G1 + Gs
        SharpB = B1 + Bs

        if(SharpR < 0):
            SharpR = 0
        elif(SharpR > 255):
            SharpR = 255

        if(SharpG < 0):
            SharpG = 0
        elif(SharpG > 255):
            SharpG = 255

        if(SharpB < 0):
            SharpB = 0
        elif(SharpB > 255):
            SharpB = 255    
        SharpImg.putpixel((x,y),(SharpB,SharpG,SharpR))    

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
ASharp = np.array(SharpImg)   

# Hiển thị hình dùng thư viện OpenCV
cv2.imshow('Anh mau RGB goc',img)
cv2.imshow('Hinh lam sac net',ASharp)

# Bấm phím bất kỳ để đóng cửa sổ hiển thị ảnh
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ
cv2.destroyAllWindows()



