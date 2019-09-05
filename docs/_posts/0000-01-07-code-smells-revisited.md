### Another three smells

* Long method
* Conditional complexity
* Large class

--

## Smell Four: Long Method

+ How long should a method be?
+ Most readable if ten lines at the most

Notes: Companies tend to have one or two thousand line methods kicking around

--

## Recognising Long Methods

+ Having to scroll…
+ Count the lines?

--

## How do methods grow to be too long?

+ Method starts small
+ I’ll just add one line…
+ I’ll just add one line…
+ I’ll just add one line…
+ It’s pretty long… one more line won’t hurt…

--

```java
    public static String formatDate(String reminderDate) {
        String dateDay = reminderDate.substring(8, 10);
        String dateMonth = reminderDate.substring(5, 7);
        String dateYear = reminderDate.substring(2, 4);
        String[] month = new String[]{"", "Jan", "Feb", "Mar", "Apr", "May",
                "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
 
        if (ZERO.equals(dateMonth.substring(0, 1))) {
            dateMonth = dateMonth.substring(1, 2);
        }
        String displayMonth = month[Integer.parseInt(dateMonth, 10)];
 
        String pattern = "";
        if (ONE.equals(dateDay) || TWENTY_ONE.equals(dateDay)
                || THIRTY_ONE.equals(dateDay)) {
            pattern = "st";
        } else if (TWO.equals(dateDay) || TWENTY_TWO.equals(dateDay)) {
            pattern = "nd";
        } else if (THREE.equals(dateDay) || TWENTY_THREE.equals(dateDay)) {
            pattern = "rd";
        } else {
            pattern = "th";
        }
 
        if (ZERO.equals(dateDay.substring(0, 1))) {
            dateDay = dateDay.substring(1, 2);
        }
 
        return dateDay + pattern + " " + displayMonth + " " + dateYear;
    }
```

--

## How to fix Long Methods

+ Extract method
+ Replace temporary variable with query
+ Introduce parameter object
+ Decompose conditional (i.e. extract methods)
+ Replace method with method object