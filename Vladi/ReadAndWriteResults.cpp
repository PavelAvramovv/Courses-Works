#pragma warning(disable : 4996)
#include <stdio.h>
#include <stdlib.h> // For exit() function
#include <string.h>
int main()
{
	char filename[100];
	char content[100];
	FILE *fop;

	printf("File za pisane: \n");
	scanf("%s", filename);
	fop = fopen(filename, "w");
	scanf("%s", content);

	printf("Content on File: %s\n", content);/*Just for debug*/
	fputs(content, fop);
	fclose(fop);

	return 0;
}