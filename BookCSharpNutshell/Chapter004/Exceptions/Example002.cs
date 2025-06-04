namespace Chapter004.Exceptions;

public static class Example002 {
    public static void Run() {
        // The using statement
        
        /*
            using (StreamReader reader = File.OpenText ("file.txt")) {
            ...
            }
            
            is precisely equivalent to the following:
            
            StreamReader reader = File.OpenText ("file.txt");
            
            try {
            ...
            } finally {
                if (reader != null) {
                    ((IDisposable)reader).Dispose();
                }
            }
         */
    }
}