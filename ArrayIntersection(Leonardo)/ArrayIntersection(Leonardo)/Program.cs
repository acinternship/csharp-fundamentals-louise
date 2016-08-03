using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program {
	
	// Array intersection problem
	public static void Main() {
		Console.WriteLine("1st array");
		int[] firstArray = ReadArray();

		Console.WriteLine("\n2nd array");
		int[] secondArray = ReadArray();
		
		// 1st solution
		IntersectUsingHashSet(firstArray, secondArray);
		
		// 2nd solution
		IntersectUsingLinq(firstArray, secondArray);
	}
	
	// Naive solution
	public static void IntersectUsingHashSet(int[] firstArray, int[] secondArray) {
		HashSet<int> hashSet = new HashSet<int>();
		
		for(int i = 0; i < firstArray.Length; i++) {
			for(int j = 0; j < secondArray.Length; j++) {
				if(firstArray[i] == secondArray[j]) {
					hashSet.Add(firstArray[i]);
				}
			}
		}

		Console.WriteLine("Intersection (HashSet): {0}", string.Join(", ", hashSet));
	}
	
	// Solution using LINQ "Intersect" method
	public static void IntersectUsingLinq(int[] firstArray, int[] secondArray) {
		var intersection = firstArray.Intersect(secondArray).ToArray();
		Console.WriteLine("Intersection (LINQ): {0}", string.Join(", ", intersection));
	}
	
	// Read an array from console (empty value to exit)
	public static int[] ReadArray() {
		List<int> list = new List<int>();
		int index = 0;
		
		while(true) {
			Console.Write("Element {0}: ", index);
			String line = Console.ReadLine();
			if(String.IsNullOrEmpty(line)) {
				break;
			}
			
			int number;
			if(int.TryParse(line, out number)) {
				list.Add(number);
				index++;
			}
			else {
				Console.WriteLine("`{0}` is not a valid number!", line);
			}
		}
		
		return list.ToArray();
	}
}