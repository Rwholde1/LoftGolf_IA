; Contains useful functions for AutoHotKey scripts

; Function to check if a pixel color is within bounds of a specified color
CheckPixelColor(x, y, expectedColor) {
    ; Get the color of the pixel at (x, y)
    PixelGetColor, color, x, y

    ; Extract B, G, R values from the colors
    b1 := (color >> 16) & 0xFF
    g1 := (color >> 8) & 0xFF
    r1 := color & 0xFF

    b2 := (expectedColor >> 16) & 0xFF
    g2 := (expectedColor >> 8) & 0xFF
    r2 := expectedColor & 0xFF

    ; Check if each color component is within +-7 of the expected color
    if (Abs(b1 - b2) <= 7 && Abs(g1 - g2) <= 7 && Abs(r1 - r2) <= 7) {
        return true
    }
    return false
}