using System;

class Prompt
{
    public string GetRandomPrompt()
    {
      var _promptList = new List<string>{
          "What were the best moments of my day?",
          "What are some things that are making me feel happy or grateful today?",
          "What are some challenges I'm facing right now and how can I overcome them?",
          "What are my biggest fears and how can I work to conquer them?",
          "What are some goals that I want to achieve in the short-term and long-term?",
          "What are some things that are causing me stress and how can I reduce or eliminate them?",
          "What are some things that I'm proud of accomplishing recently?",
          "What are some things that I'm learning about myself and the world around me?",
          "What are some ways I can improve my relationships with the people in my life?",
          "What are some things that I'm passionate about and how can I incorporate them more into my life?"
      };
      
      Random rnd = new Random();
      int index = rnd.Next(0, _promptList.Count);
      return _promptList.ElementAt(index);
    }
}