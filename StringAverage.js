function averageString(str) {
  // Code away
  var int = new Object();
  int["zero"] = 0;
  int["one"] = 1;
  int["two"] = 2;
  int["three"] = 3;
  int["four"] = 4;
  int["five"] = 5;
  int["six"] = 6;
  int["seven"] = 7;
  int["eight"] = 8;
  int["nine"] = 9;
  int[0] = "zero";
  int[1] = "one";
  int[2] = "two";
  int[3] = "three";
  int[4] = "four";
  int[5] = "five";
  int[6] = "six";
  int[7] = "seven";
  int[8] = "eight";
  int[9] = "nine";
  
  var words = str.split(" ");
  var total = 0;
  for (var i = 0; i < words.length; i++) {
    var x = (int[words[i]]);
    total = total + x;
  }
  var avg = Math.floor(total/words.length)
  var result = int[avg]
  if (result == null || result > 9) {
    return "n/a"
  }else {
    return result
    }
}
