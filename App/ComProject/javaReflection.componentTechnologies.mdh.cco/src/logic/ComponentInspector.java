package logic;

import interfaces.Inspector;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;

import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLClassLoader;

import java.util.LinkedList;
import java.util.TreeMap;
import java.util.List;
import java.util.jar.JarEntry;
import java.util.jar.JarInputStream;

public class ComponentInspector implements Inspector {

	public URLClassLoader getClassLoader(String jarPath) throws MalformedURLException {

		URLClassLoader cl = null;

		try {
			File jarFile = new File(jarPath);
			cl = URLClassLoader.newInstance(new URL[] { new URL("jar:file:" + jarFile + "!/") });
		}

		catch (MalformedURLException e) {
			e.printStackTrace();
			return null;
		}

		return cl;

	}

	public JarInputStream getJarInputStream(String jarPath) throws FileNotFoundException, IOException {

		JarInputStream jis = null;
		FileInputStream fis = null;

		try {
			File jarFile = new File(jarPath);
			fis = new FileInputStream(jarFile);
			jis = new JarInputStream(fis);
		}

		catch (FileNotFoundException f) {
			f.printStackTrace();
			jis = null;
		}

		catch (IOException i) {
			i.printStackTrace();
			jis = null;
		}

		return jis;

	}

	@SuppressWarnings("rawtypes")
	public Class getClass(String className, URLClassLoader ucl) throws ClassNotFoundException {

		Class cls;

		try {
			cls = ucl.loadClass(className);
		}

		catch (ClassNotFoundException cnfe) {
			cnfe.printStackTrace();
			cls = null;
		}

		return cls;

	}

	@SuppressWarnings("rawtypes")
	public TreeMap<String, LinkedList<String>> inspect(String jarPath)
			throws FileNotFoundException, IOException, ClassNotFoundException {

		URLClassLoader ucl = this.getClassLoader(jarPath);
		JarInputStream jis = this.getJarInputStream(jarPath);

		LinkedList<String> classes = new LinkedList<String>();
		LinkedList<String> interfaces = new LinkedList<String>();

		TreeMap<String, LinkedList<String>> result = new TreeMap<String, LinkedList<String>>();

		if (ucl != null && jis != null) {

			String className;
			Class cls;

			JarEntry je = jis.getNextJarEntry();

			while (je != null) {

				if (je.getName().endsWith(".class")) {

					className = je.getName().replaceAll("/", "\\.");
					className = className.substring(0, je.getName().length() - 6);
					cls = this.getClass(className, ucl);

					if (cls == null) {
						break;
					}

					if (cls.isInterface()) {
						interfaces.add(cls.getName());
					} else {
						classes.add(cls.getName());
					}

				}
				je = jis.getNextJarEntry();
			}

		}

		result.put("Classes", classes);
		result.put("Interfaces", interfaces);

		return result;
	}

	public List<String> getClasses(String filePath) throws FileNotFoundException, ClassNotFoundException, IOException {
		return this.inspect(filePath).get("Classes");
	}

	public List<String> getInterfaces(String filePath)
			throws FileNotFoundException, ClassNotFoundException, IOException {
		return this.inspect(filePath).get("Interfaces");
	}

}
