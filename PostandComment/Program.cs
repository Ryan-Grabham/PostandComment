using System;

namespace PostandComment
{
    class Program
    {
        static void Main(string[] args)
        {
            //user class - to assign author role
            User user1 = new User("RyanG");
            User user2 = new User("DominicT");
            User user3 = new User("CefysT");

            //create a post
            Post post1 = new Post(user1, "LOL, so funny. cefys shitted again");

            //add comments
            post1.comments.Add(new Comment(user2, "ffs cef, not again!! XD LOL"));
            post1.comments.Add(new Comment(user3, "oh, come on guys. dont tell everyone!:("));

            //create methods
            Console.WriteLine($"Author: {post1.author.username}\nPost: {post1.post}\nPosted: {post1.timeStamp}\n");

            foreach (Comment comment in post1.comments)
            {
                Console.WriteLine($"        Post: {comment.comment}\n        Author: {comment.author.username}\n        Posted: {comment.timeStamp}\n");
            }

            //create a post
            Post post2 = new Post(user3, "LOL, i didnt poo myself!. my friends are so funny HAHA");

            //add comments
            post2.comments.Add(new Comment(user1, "yeah right cef!! whatever lol ;)"));
            post2.comments.Add(new Comment(user2, "HAHA trying to cover up!!"));

            //create methods
            Console.WriteLine($"Author: {post2.author.username}\nPost: {post2.post}\nPosted: {post2.timeStamp}\n");

            foreach (Comment comment in post2.comments)
            {
                Console.WriteLine($"        Post: {comment.comment}\n        Author: {comment.author.username}\n        Posted: {comment.timeStamp}\n");
            }



            //post class - which is going to create posts
            //comment class - going to be used to update actions on posts

            //methods
            //view posts
            //comment on posts
            //close or delete posts

        }
    }
}
