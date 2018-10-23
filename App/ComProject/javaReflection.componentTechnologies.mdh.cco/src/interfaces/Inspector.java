package interfaces;

import java.util.TreeMap;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.LinkedList;;

public interface Inspector {

	@SuppressWarnings("rawtypes")
	public TreeMap<String, LinkedList<Class>> inspect(String filePath) throws FileNotFoundException, IOException, ClassNotFoundException;
	
}
