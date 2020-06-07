#include <stdio.h>
#include <string.h>

#pragma warning(disable : 4996)
int main()
{
	int arr[100];
	int counter[201] = { 0 };
	int i;
	int size = 0;
	int maximum = 0;
	int pos = 0;
	int toSearch = 0;
	bool found = 0;
	char command[50]{ 0 };


	printf("Enter Array Size : ");
	scanf("%d", &size);
	printf("Enter array elements : ");
	for (int i = 0; i < size; i++)
	{
		scanf("%d", &arr[i]);
	}

	while (true)
	{
		printf("command(read/print/save/result/exit): ");//Command Print
		scanf_s("%s", &command, 50);

		if (strcmp(command, "exit") == 0)
			break;
		else if (strcmp(command, "print") == 0)
		{

			printf("Now the new array is : \n");
			for (int i = 0; i < size; i++)
			{
				printf("%d \n", arr[i]);
			}

		}
		else if (strcmp(command, "read") == 0)
		{
			FILE* myFile;
			myFile = fopen("somenumbers.txt", "r");

			//read file into array
			int numberArray[16];
			int i;

			if (myFile == NULL) {
				printf("Error Reading File\n");
				return 0;
			}

			for (i = 0; i < 16; i++) {
				fscanf(myFile, "%d,", &numberArray[i]);
			}

			for (i = 0; i < 16; i++) {
				printf("Number is: %d\n\n", numberArray[i]);
			}

			fclose(myFile);

		}
		else if (strcmp(command, "search") == 0)  //Command Search
		{
			printf("\nEnter element to search: ");
			scanf("%d", &toSearch);

			int i = 0;
			for (i; i < size; i++)
			{
				/*
				 * If element is found in array then raise found flag
				 * and terminate from loop.
				 */
				if (arr[i] == toSearch)
				{
					found = true;
					break;
				}
			}

			/*
			* If element is not found in array
			*/
			if (found == true)
			{
				printf("\n%d is found at position %d \n", toSearch, i + 1);
			}
			else
			{
				printf("\n%d is not found in the array \n", toSearch);
			}
		}
		else if (strcmp(command, "result") == 0)  //Command result
		{

			for (int i = 0; i < size; i++)
			{

				if (arr[i] < 100 && arr[i] > 0)
				{
					++counter[arr[i] + 100];
				}

				else {
					++counter[arr[i]];
				}

			}

			maximum = counter[0];
			for (i = 0; i < 201; i++) {
				if (counter[i] > maximum) {
					maximum = i - 100;
				}
			}
			printf("The maximum repeating number: %d \n", maximum);


		}
		else if (strcmp(command, "save") == 0)  //Command save
		{
			FILE *fptr;
			if ((fptr = fopen("array.txt", "w+")) == NULL)
			{
				printf("Error! opening file");

			}
			fwrite(&arr[i], sizeof(int), 1, fptr);
			//fwrite(&maximum, sizeof(int), 1, fptr);
			//fwrite(&toSearch, sizeof(int), 1, fptr);

			if (fwrite != 0)
				printf("Contents to file written successfully !\n");
			else
				printf("error writing file !\n");
		}



		//break;
	}
}
