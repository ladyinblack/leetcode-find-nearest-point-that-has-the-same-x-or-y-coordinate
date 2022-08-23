public int NearestValidPoint(int x, int y, int[][] points) {
    int idx = -1;
    int maxVal = Int32.MaxValue;
    int distance = 0;
    
    for (int i = 0; i < points.Length; i++) {
        if (points[i][0] == x || points[i][1] == y) {
            distance = Math.Abs(points[i][0] - x) + Math.Abs(points[i][1] - y);
            if (distance < maxVal) {
                maxVal = distance;
                idx = i;
            }
        }
    }
    return idx;
}
