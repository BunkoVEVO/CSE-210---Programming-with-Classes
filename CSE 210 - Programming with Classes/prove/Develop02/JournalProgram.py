import random
from datetime import datetime

class Journal:
    def __init__(self):
        self.prompts = {
            "How was your day?": False,
            "How is your family?": False,
            "What was the weather like today?": False,
            "What was fun today?": False,
            "How was work today?": False
        }
        self.responses = []
    
    def show_menu(self):
        print("\nMenu")
        print("1. Write a new entry")
        print("2. Display the journal")
        print("3. Exit")
    
    def display_entry(self):
        if not self.responses:
            print("\nNo journal entries yet.")
        else:
            print("\nJournal Entries:")
            for response in self.responses:
                print(response)
    
    def write(self):
        unanswered_questions = [q for q, answered in self.prompts.items() if not answered]
        if not unanswered_questions:
            print("\nNo more prompts available.")
            return
        
        random_question = random.choice(unanswered_questions)
        self.prompts[random_question] = True
        print(f"\n{random_question}")
        
        answer = input("Your response: ").strip()
        while not answer:
            print("Response cannot be empty.")
            answer = input("Your response: ").strip()
        
        date = datetime.now().strftime("%d/%m/%Y")
        self.responses.append(f"Date: {date} - Prompt: {random_question} - {answer}")
    
    def run(self):
        while True:
            self.show_menu()
            choice = input("\nEnter your choice: ").strip()
            
            if choice == "1":
                self.write()
            elif choice == "2":
                self.display_entry()
            elif choice == "3":
                print("\nExiting the journal. Goodbye!")
                break
            else:
                print("\nInvalid choice. Please try again.")

# Run the journal
if __name__ == "__main__":
    journal = Journal()
    journal.run()