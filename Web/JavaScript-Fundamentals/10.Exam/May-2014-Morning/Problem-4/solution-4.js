function s(p) {
    if (p[0] > 0) {
        if (p[1] > 0) {
            return 1;
        }
        return 3;
    } else {
        if (p[1] > 0) {
            return 0;
        }
        return 2;
    }
}