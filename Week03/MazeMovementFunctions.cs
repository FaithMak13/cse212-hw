using System.Collections.Generic;

static class MazeMovementFunctions
{
    // Maze is Dictionary<(int x, int y), (bool left, bool right, bool up, bool down)>
    public static (int x, int y) MoveLeft(Dictionary<(int x, int y), (bool left, bool right, bool up, bool down)> maze, (int x, int y) current)
    {
        var cell = maze[current];

        if (cell.left)
            return (current.x - 1, current.y);

        return current;
    }

    public static (int x, int y) MoveRight(Dictionary<(int x, int y), (bool left, bool right, bool up, bool down)> maze, (int x, int y) current)
    {
        var cell = maze[current];

        if (cell.right)
            return (current.x + 1, current.y);

        return current;
    }

    public static (int x, int y) MoveUp(Dictionary<(int x, int y), (bool left, bool right, bool up, bool down)> maze, (int x, int y) current)
    {
        var cell = maze[current];

        if (cell.up)
            return (current.x, current.y - 1);

        return current;
    }

    public static (int x, int y) MoveDown(Dictionary<(int x, int y), (bool left, bool right, bool up, bool down)> maze, (int x, int y) current)
    {
        var cell = maze[current];

        if (cell.down)
            return (current.x, current.y + 1);

        return current;
    }
}