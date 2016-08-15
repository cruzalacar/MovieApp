# README #

This is the new project. As the project name suggests it allows a user to write a review on a movie. They may also view existing reviews that have been saved on a document. I need some input for what classes are needed.

## ***What has been done so far:*** ##

## MainPage   (finished)
    * design 
    * all buttons work

## WriteReviewPage
    * design
    * comboboxes contain some items
    * submit button (it will show a messagebox and set the boxes to default)

## ReadReviewPage
    * design
    * combobox containing same movie titles as in the WRP

## ***What needs to be done:*** ##

## WriteReviewPage
     * need to take all inputted info and write it to document

## ReadReviewPage
     * when a movie is selected, the first review will be retrieved from a document an
       display in the textblock.
     * back and next button will display the reviews one at a time

## Program Class (business logic)
     * will contain methods: LoadReview, SaveReview, RetrieveReview, LoadTitles
     * LoadReview will load all existing reviews objects, calls  read from DS class 
       (will only be called once)
     * SaveReview will call the write method from DS class 
     * RetrieveReview  will access reviewList in DS class and display it in textBlock
     * LoadTitles will read textfile and load all titles into comboboxes

## DataStorage Class (data persistance) 
     * retrieves all information from the WRP
     * Contain methods read, write, retrieve and reviewList
     * Read loads data at program start. Read text document, if there is an existing
       review it creates a new review object and stores it in the reviewList
     * Write creates a new review object when it is submitted from the WRP
     * Retrieve returns a review object and displays it in the textblock
     
## Review Class (business logic)
     * Contains the attributes name, rating, description and author
     * get/set methods

## Author Class (business logic)
     * each review has an author
     * the idea is to be able to search for a specific author and read their reviews

## Movie Class (business logic)
     * contains a list of movie titles from a text file that will be loaded to the
       comboboxes this so that it is not hardcoded 

## ***Project Links:*** ##
[Project Proposal](https://docs.google.com/document/d/1a7Y5dT7Xj-zFmzVo3-7A2HPYRfFKxr6-vuBViNEMx2I/edit?usp=sharing)