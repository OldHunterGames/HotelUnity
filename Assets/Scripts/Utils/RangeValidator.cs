using UnityEngine;
using System.Collections;

namespace Utils {

	public class RangeValidator {

		public static int validate(int value, int minValue, int maxValue) {
			int result = 0;

			if (value > maxValue) {
				result = maxValue;
			} else if (value < minValue) {
				result = minValue;
			} else {
				result = value;
			}

			return result;
		}
	}
}