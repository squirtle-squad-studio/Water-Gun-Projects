# Water Gun Projects - Learning Git

All Git related learning files will go here

## Getting Set Up

Before we jump right in, we need to make sure our GitHub is configured.
The link below will guide you in generating an SSH key and adding it to your
GitHub account to make a connection. If you already have a key, follow the
appropriate link to connect it to your GitHub:

* [Connecting to GitHub](https://help.github.com/en/articles/connecting-to-github-with-ssh)

### Clone the Repo

Make sure you grab the files for this repo by cloning it:

```
git clone git@github.com:squirtle-squad-studio/Water-Gun-Projects.git
```

## Getting Started

All members of Squirtle Squad Studio will learn to make a change to the 
"completed-names.txt" file in order to include our names.

## Steps

1. Before making any changes to the "completed-names.txt", make sure to 
"check-out" the branch that we will be using to make these changes:
(use the "learngit" branch)

```
git checkout learngit
```

2. Next, make sure to have all the updated changes on this branch:

```
git pull origin master
```

3. Now, you are ready to make changes to the "completed-names.txt" file! Open 
it up in your favorite text editor and add your name to the bottom of this file 
and save!

4. Now we are ready to update the changes we made. First, we can add the 
"completed-names.txt" file to the staging area:

```
git add completed-names.txt
```

5. Next, make a commit. Leave a commit message on the changes you made in 
between the quotation marks:

```
git commit -m "your message"
```

6. As good practice, before we push our changes onto our branch, we want to
make sure we did not accidently make other changes:

```
git status
```

7. If everything looks good (green is always good), we are ready to move on.
Otherwise, examine the changes that were made and revise accordingly. If you
need to go back to the start, try the following:

```
git revert learngit
```

8. Finally, we can push the changes we made to this branch to the remote repo 
that others can also view and make changes to:

```
git push -u origin learngit
```

9. If everything goes smoothly, all your changes should have been made to the 
branch. Now we can add the changes made to this branch to the master branch:

```
git checkout master
git pull origin master
git merge learngit
git push origin master
```

10. Verify you have merged correctly. These are the basics to working with Git!
