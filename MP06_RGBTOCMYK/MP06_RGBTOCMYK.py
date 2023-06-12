# Library imported
import cv2                       
import numpy as np                 
from PIL import Image

# Photo path
path = "D:\Code\Adruino\Pycharm\Project\Image Processing\Lena.jpg"
# Read image by opencv
img = cv2.imread(path, cv2.IMREAD_COLOR)

# Read image by PIL
img_PIL = Image.open(path)

# Create an image with the same size & mode with img_PIL to store result values from the process
C = Image.new(img_PIL.mode, img_PIL.size)
M = Image.new(img_PIL.mode, img_PIL.size)
Y = Image.new(img_PIL.mode, img_PIL.size)
K = Image.new(img_PIL.mode, img_PIL.size)

# Get the size value of image
width = img_PIL.size[0]
height = img_PIL.size[1]

# Each image is a 2D matrix, use 2 loop to read all pixels exist
for i in range(width):
    for j in range(height):
        R, G, B = img_PIL.getpixel((i, j))
        # Mix color to generate CMYK
        # C (xanh duong = G + B, R = 0), M (purple = B + R, G = 0), Y (yellow = G + R, B = 0)
        C.putpixel((i, j), (B, G, 0))
        M.putpixel((i, j), (B, 0, R))    # mau tim
        Y.putpixel((i, j), (0, G, R))   # mau vang

        # B (black = gray = min(R,G,B) in RGB)
        Min = min(R, G, B)
        black = Min
        K.putpixel((i, j), (black, black, black))

ImageC = np.array(C)
ImageM = np.array(M)
ImageY = np.array(Y)
ImageK = np.array(K)

# Show image by Opencv
cv2.imshow("Original", img)

cv2.imshow("Channel Cyan", ImageC)

cv2.imshow("Channel Magenta", ImageM)
cv2.imshow("Channel Yellow", ImageY)
cv2.imshow("Channel Key (Black)", ImageK)

# Press any button to close the display window
cv2.waitKey(0)

# Free up display window
cv2.destroyAllWindows()
