package interfaces;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.List;

public interface Inspector {
	public List<String> getClasses(String filePath) throws FileNotFoundException, IOException, ClassNotFoundException; 
	public List<String> getInterfaces(String filePath) throws FileNotFoundException, IOException, ClassNotFoundException;
}
