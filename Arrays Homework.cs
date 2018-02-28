//Unlike functions that use (), Arrays use []
public GameObject[] title;

//An example of Arrays look like this
myArray[0] = cat;
myArray[1] = dog;
myArray[2] = fish;

/* Arrays work like a list that contains likewise items.
    It's pesky to write myArray over and over again, so we can write
    Arrays all in one line like this */
int[] myArray = {cat, dog, fish};

/* Arrays assign numbers to the values in side them.
   Arrays do not count starting from One, they start from Zero. 
   If I was to number the array above it would look like this */
int[] myArray ={0, 1, 2}

/* Arrays are helpful for finding certain objects in our game. 
   Think about it you wanted to find all of our Chickens, we could
   use .FindGameObjectWithTag to find them using an array. */

Public GameObject[] chickens;

void void Start()
{
    chickens = GameObject.FindGameObjectWithTag("Chickens");
}

/*Arrays make use of loops. Loops will iterate through our array. 
  Say we wanted to count figure out how many chickens
  we have in our map. We could count them using a loop */

    for(int i = 0; i < chickens.Length; i++)
    {
        Debug.Log("There are "+i+" Many chickens" +chickens[i].chickens);
    }
    
//Some Examples
//Public Array
Public int[] cats = new int[13];
//Private Array
int[] cats = new int[13];

//More Examples
Public int[] birds = {raven, crow, owl};
Public int[0] = raven;
Public int[1] = crow;
Public int[2] = owl;
int [3] = secretBird;

