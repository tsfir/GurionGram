using System;


class Program {

  public static void Main (string[] args) {

    ______ userDana = new ____();
    userDana._____ = "Dana";   // שם פרטי
    userDana.lastName = _____;  // שם משפחה
    
    ______ userKeren = ___ ____();
    userKeren._____ = ____ ;   // שם פרטי
    userKeren._____ = _____;  // שם משפחה

    ______ userRon = ___ ____();
    userRon._____ = ____ ;   // שם פרטי
    userRon._____ = _____;   // שם משפחה
    userRon.statusArr = new ______[3];
    userRon.statusArr___ = _____;   // סטאטוס ראשון
    userRon.statusArr___ = _____;   // סטאטוס שני
    userRon.statusArr___ = _____;   // סטאטוס שלישי

    ______ post1 = ___ ____();
    ____                     ; // טקסט פוסט1
    ____                     ; // תמונה פוסט1
    ____                     ; // כמות לייקים פוסט1
    ____                     ; // 1כמות שיתופים פוסט
    post1.user = _____ ;      // כותב.ת פוסט1
    post1.commentsArr = new ______[3];
    
    post1.commentsArr____ = new ______();   // יצירת תגובה ראשונה בפוסט1
    post1.commentsArr____.text = _____ ;   // טקסט תגובה ראשונה בפוסט1
    post1.commentsArr____.user = _____ ;   // המשתמש.ת שכתב.ה את התגובה לפוסט1
    
    post1.commentsArr____ = new ______();   // יצירת תגובה שניה בפוסט1
    post1.commentsArr____.text = _____ ;   // טקסט תגובה שניה בפוסט1
    post1.commentsArr____.user = _____ ;   // המשתמש.ת שכתב.ה את שניה לפוסט1

    post1.commentsArr____ = new ______();   // יצירת תגובה שלישית בפוסט1
    post1.commentsArr____.text = _____ ;   // טקסט תגובה שלישית בפוסט1
    post1.commentsArr____.user = _____ ;   // המשתמש.ת שכתב.ה את שלישית לפוסט1

    
    ______ post2 = ___ ____();
    ____                     ; // טקסט פוסט2
    ____                     ; // תמונה פוסט2
    ____                     ; // כמות לייקים פוסט2
    ____                     ; // כמות שיתופים פוסט2
    ____                     ;  // כותב.ת פוסט2


    _____ postArr = new ______[2];   // ייצירת מערך פוסטים
    postArr[_] = ____;               // פוסט ראשון במערך
    postArr[_] = ____;               // פוסט שני במערך


    Console.WriteLine("****************************************");
    Console.WriteLine("*  Welcome to the GREAT social media Nextwork    *");
    Console.WriteLine("*                 GurionGram                     *");
    Console.WriteLine("****************************************");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("****************************************");
    Console.WriteLine("* Friends   *");
    Console.WriteLine("****************************************");
    Console.WriteLine("");
    Console.WriteLine("First Frined: " + ______ + " " + ______);  // שם פרטי ושם משפחה של משתמש דנה
    Console.WriteLine("Second Frined: " + ______ + " " + ______);  // שם פרטי ושם משפחה של משתמש קרן
    Console.WriteLine("");
    Console.WriteLine("****************************************");
    Console.WriteLine("* Profile   *");
    Console.WriteLine("****************************************");
    Console.WriteLine("");
    Console.WriteLine("Your name: " + ______ + " " + ______);  // שם פרטי ושם משפחה של משתמש רון
    Console.WriteLine("Your current status: " + ______);  // הטאטוס האחרון שהוזן למשתמש רון 
    Console.WriteLine("");
    Console.WriteLine("****************************************");
    Console.WriteLine("* Feed   *");
    Console.WriteLine("****************************************");
    Console.WriteLine("");
    for (int i=0; i<postArr.Length; i++){
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Post Text: " + ______ );  // הטקסט של הפוסט הנוכחי במערך הפוסטים
      Console.WriteLine("Post pic: " + ______ );  // התמונה של הפוסט הנוכחי במערך הפוסטים
      Console.WriteLine("Post likes: " + ______ );  // כמות הלייקים של הפוסט הנוכחי במערך הפוסטים
      Console.WriteLine("Post shares: " + ______ );  // כמות השיתופים של הפוסט הנוכחי במערך הפוסטים
      Console.WriteLine("Post Celeb Rate: " + ______ );  // ממוצע בין השיתופים לליקים
      Console.WriteLine("Post Author: " + ______ + " " + ____ );  // השפ הפרטי ומשפחה של הפוסט הנוכחי 
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Comments : ")
      if (______)   // בדיקה אם מערך התגובות של הפוסט הנוכחי במערך הינו ריק כלומר שווה ל Null
      {
        Console.WriteLine("Enter the first comment");
      }
      else
      {
          for (int j=0; i<postArr[_]._____.length;j++)
          {
            Console.WriteLine("Comment : " + ____[i]._____[j].______);   // הטקסט של התגובה הנוכחית 
            Console.WriteLine("Comment Author : " + ____[i]._____[j].______.firstName);   // השם הפרטי של הכותב של התגובה הנוכחית 
          }
        
      }
      Console.WriteLine("-----------------------------------------");
    }
    
  }
}