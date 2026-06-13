Assuming:
maze is Dictionary<(int x, int y), (bool left, bool right, bool up, bool down)>
current is a (int x, int y) position

public (int x, int y) MoveLeft((int x, int y) current)
{
    var cell = maze[current];

    if (cell.left)
        return (current.x - 1, current.y);

    return current;
}