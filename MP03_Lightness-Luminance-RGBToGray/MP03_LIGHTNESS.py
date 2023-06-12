# Library imported
import cv2
import numpy as np
from PIL import Image

# Photo path
path = "D:\Code\Adruino\Pycharm\Project\Lena.jpg"

# Read image by opencv
img = cv2.imread(path, cv2.IMREAD_COLOR)

# Read image by PIL
img_PIL = Image.open(path)

# Create an image with the same size & mode with img_PIL to store result values from the process
lightness = Image.new(img_PIL.mode, img_PIL.size)

# Get the size value of image
width = lightness.size[0]
height = lightness.size[1]

# Each image is a 2D matrix, use 2 loop to read all pixels exist
for i in range(width):
    for j in range(height):
        R, G, B = img_PIL.getpixel((i, j))
        # Formula of Lightness
        minimum = min(R, G, B)
        maximum = max(R, G, B)
        gray = np.uint8((minimum + maximum)/2)

        # Import value of grayscale to image
        lightness.putpixel((i, j), (gray, gray, gray))

# Exchange data
img_gray = np.array(lightness)

# Open img_PIL by opencv
cv2.imshow("Original Image", img)
cv2.imshow("Gray Image", img_gray)

# Press any button to close the display window
cv2.waitKey(0)

# Free up display window
cv2.destroyAllWindows()





