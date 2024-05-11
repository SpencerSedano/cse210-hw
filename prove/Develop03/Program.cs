using System;

class Program
{
    static void Main(string[] args)
    {
        List<Reference> references = new List<Reference>();

        Reference reference1 = new Reference("1 Nephi", 3, 7, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Reference reference2 = new Reference("Moroni", 10, 32, "Yea, acome unto Christ, and be perfected in him, and cdeny yourselves of all ungodliness; and if ye shall deny yourselves of all ungodliness, and dlove God with all your might, mind and strength, then is his grace sufficient for you, that by his grace ye may be eperfect in Christ; and if by the grace of God ye are perfect in Christ, ye can in nowise deny the power of God.");
        Reference reference3 = new Reference("Moses", 1, 39, "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");
        Reference reference4 = new Reference("2 Nephi", 28, 7, 9, "7 Yea, and there shall be many which shall say: Eat, drink, and be merry, for tomorrow we die; and it shall be well with us. 8 And there shall also be many which shall say: Eat, drink, and be merry; nevertheless, fear God—he will justify in committing a little sin; yea, lie a little, take the advantage of one because of his words, dig a pit for thy neighbor; there is no harm in this; and do all these things, for tomorrow we die; and if it so be that we are guilty, God will beat us with a few stripes, and at last we shall be saved in the kingdom of God. 9 Yea, and there shall be many which shall teach after this manner, false and vain and foolish doctrines, and shall be puffed up in their hearts, and shall seek deep to hide their counsels from the Lord; and their works shall be in the dark.");
        references.Add(reference1);
        references.Add(reference2);
        references.Add(reference3);
        references.Add(reference4);

 /*        Reference reference1 = new Reference("1 Nephi", 3, 7, "Hello there"); */
        Random myRandomScripture = new Random();
        int myRandomNumber = myRandomScripture.Next(0, 5);

        Scripture scripture1 = new Scripture($"{references[myRandomNumber].GetCompleteVerse()}");

        string exit = "";

        while (exit != "quit" && !scripture1.IsCompletelyHidden()) // This will return to false, but I want to the opposite, that's why is !
        {
            Console.Clear();
            Console.WriteLine(references[myRandomNumber].GetDisplayText());
            Console.WriteLine(scripture1.GetDisplayText());

            Console.WriteLine("Press enter to hide words or write 'quit' to exit");
            exit = Console.ReadLine();

            if (exit.ToLower() != "quit")
            {
                scripture1.HideRandomWords(3); // Hide 3 random words at a time
            }
        }


    }
}