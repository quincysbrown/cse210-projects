using System;

class ScriptureLibrary
{
    private List<Scripture> _scripture = new List<Scripture>();
    public ScriptureLibrary()
    {
        _scripture.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), 
        "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct they paths."
        ));

        _scripture.Add(new Scripture(new Reference("John", 3, 16), 
        "For God so loved the world that he gave his only begotten son, that whosoever believeth in him should not perish, but have everlasting life."
        ));

        _scripture.Add(new Scripture(new Reference("John", 3, 16, 17), 
        "For God so loved the world that he gave his only begotten son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world but that the world through him might be saved."
        ));

        _scripture.Add(new Scripture(new Reference("2 Nephi", 2, 25), 
        "Adam fell that men might be; and men are, that they might have joy."
        ));

        _scripture.Add(new Scripture(new Reference("Alma", 41, 10), 
        "Do not suppose, because it has been spoken concerning restoration, that ye shall be restored from sin to happiness. Behold, I say unto you, wickedness never was happiness."
        ));

        _scripture.Add(new Scripture(new Reference("Mosiah", 2, 17), 
        "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."
        ));

        _scripture.Add(new Scripture(new Reference("Mosiah", 3, 19), 
        "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh aa saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him even as a child doth submit to his father."
        ));
        

    }

    public Scripture GetRandomScripture()
    {
        Random rnd = new Random();
        int index = rnd.Next(_scripture.Count);
        //return the random prompt to the program.
        return _scripture[index];
    }
}