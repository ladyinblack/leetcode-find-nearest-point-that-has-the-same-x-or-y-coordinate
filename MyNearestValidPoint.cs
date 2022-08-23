public static int NearestValidPoint(int x, int y, int[,] points) {
    int idx = -1;
    int maxVal = Int32.MaxValue;
    int distance = 0;
    for (inti = 0; i < points.GetLength(0); i++) {
        if (points[i,0] == x || points[i,1] == y) {
            distance = Math.Abs(points[i,0] - x) + Math.Abs(points[i,1] - y);
            if (distance < maxVal) {
                maxVal = distance;
                idx = i;
            }
        }
    }
    return idx;
}
