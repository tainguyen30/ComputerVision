# Library imported
import cv2
import numpy as np
import matplotlib.pyplot as plt
from PIL import Image


def RGBtoGrayLuminance(img_PIL):
    # Create an image with the same size & mode with img_PIL to store result values from the process
    average = Image.new(img_PIL.mode, img_PIL.size)

    # Get the size value of image
    width = average.size[0]
    height = average.size[1]

    # Each image is a 2D matrix, use 2 loop to read all pixels exist
    for i in range(width):
        for j in range(height):
            R, G, B = img_PIL.getpixel((i, j))
            # Formula of Average
            gray = np.uint8(0.2126 * R + 0.7152 * G + 0.0722 * B)
            # Import value of grayscale to image
            average.putpixel((i, j), (gray, gray, gray))
    return average


# Calculate histogram of gray image
def CalculateHistogram(grayPIL):
    # Each pixel has value from 0-255 -> have to define an array of 256 values
    histogram = np.zeros(256)
    # Image size
    width = grayPIL.size[0]
    height = grayPIL.size[1]
    for x in range(width):
        for y in range(height):
            # Get the gray value at (x,y)
            gR, gG, gB = grayPIL.getpixel((x, y))
            # The output gray value calculated is the "gray" element in the histogram defined before
            # Increase the count of "gray" element to 1
            histogram[gR] += 1
    return histogram


# Draw histogram using matplotlib library
def DrawHistogram(his):
    width = 5
    height = 4
    plt.figure("Gray Image Histogram", figsize=(width, height), dpi=100)
    X_axis = np.zeros(256)
    X_axis = np.linspace(0, 256, 256)
    plt.plot(X_axis, his, color="orange")
    plt.title("Histogram")
    plt.xlabel("Gray value")
    plt.ylabel("Points that have the same gray value")
    plt.show()


# Main program
path = "D:\Code\Adruino\Pycharm\Project\Image Processing\Lena.jpg"

# Read image by PIL
img_PIL = Image.open(path)

# Change to gray image
grayPIL = RGBtoGrayLuminance(img_PIL)

# Calculate histogram
his = CalculateHistogram(grayPIL)

# Change from PIL to Opencv
graycv = np.array(grayPIL)
cv2.imshow("Gray Image", graycv)

# Show histogram
DrawHistogram(his)

# Press any button to close the display window
cv2.waitKey(0)

# Free up display window
cv2.destroyAllWindows()
