class Rectangle
{
    public string Id { get; }
    public int Width { get; }
    public int Height { get; }
    public int x0 { get; }
    public int y0 { get; }

    public Rectangle(string Id, int Width, int Height, int x0, int y0)
    {
        this.Id = Id;
        this.Width = Width;
        this.Height = Height;
        this.x0 = x0;
        this.y0 = y0;
    }

    public bool CheckIntersection(Rectangle OtherRectangle)
    {
        // Checks if our rectangle's left edge is to the left of the rigth edge of the other rectengle
        // and if our rentangle's right edge is to the right of the left edge of the other rectangle
        bool horizontalIntersection = this.x0 <= (OtherRectangle.x0 + OtherRectangle.Width) &&
            (this.x0 + this.Width) >= OtherRectangle.x0;

        // Checks if our rectangle's top edge is above the bottom edge of the other rectengle
        // and if out rentangle's bottom edge under the top edge of the other rectangle
        bool verticalIntersection = this.y0 <= (OtherRectangle.y0 + OtherRectangle.Height) &&
            (this.y0 + this.Height) >= OtherRectangle.y0;

        return horizontalIntersection || verticalIntersection;
    }
}