public class CollisionDetector
{
    /// <summary> 
    /// Calculates if rectangles describing two sprites 
    /// are overlapping on screen. 
    /// </summary> 
    /// <param name="s1">First sprite</param> 
    /// <param name="s2">Second sprite</param> 
    /// <returns>Returns true if overlapping</returns>
    public static bool Overlaps(Sprite s1, Sprite s2)
    {
        if(s1.Position.X < s2.Position.X + s2.Size.Right &&
            s1.Position.X + s1.Size.Right > s2.Position.X &&
            s1.Position.Y < s2.Position.Y + s2.Size.Bottom &&
            s1.Position.Y + s1.Size.Bottom > s2.Position.Y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
