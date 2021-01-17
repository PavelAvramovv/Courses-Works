#pragma warning(disable : 4996)
#include <stdio.h>
#include <stdlib.h> // For exit() function
#include <string.h>

int main()
{
	char filename[100];
	char c;
	int command = 0;
	char b[100] = "";
	int line_count1 = 0, n_o_c_l1 = 0, n_o_n_b_l1 = 0, n_o_b_l1 = 0, n_e_c1 = 0;
	char  arrr[100];// = "asd.txt";/*In progress insert scanf*/
	FILE *fp1;
	char ch;

	printf("Ime na fail:");
	scanf("%s", arrr);
	fp1 = fopen(arrr, "r");

	while ((ch = fgetc(fp1)) != EOF)
	{
		if (ch == '\n')
		{
			line_count1++;
		}
		if (ch == '\n')
		{
			if ((ch = fgetc(fp1)) == '\n')
			{
				fseek(fp1, -1, 1);
				n_o_b_l1++;
			}
		}
		if (ch == ';')
		{
			if ((ch = fgetc(fp1)) == '\n')
			{
				fseek(fp1, -1, 1);
				n_e_c1++;
			}
		}
	}
	fseek(fp1, 0, 0);
	while ((ch = fgetc(fp1)) != EOF)
	{
		if (ch == '/')
		{
			if ((ch = fgetc(fp1)) == '/')
			{
				n_o_c_l1++;
			}
		}
	}

	printf("Total no of blank lines: %d\n", n_o_b_l1);
	/*Zapisvane na rezultata vuv faila ! */
	char  arrr2[100];
	printf("Ime na fail za zapis na rezultata:");
	scanf("%s", arrr2);
	FILE* fop2222;
	fop2222 = fopen(arrr2, "w");
	//printf("%d", n_o_b_l);/*J*/
	fprintf(fop2222, "Prazni redove:");
	fprintf(fop2222, "%d", n_o_b_l1);/*Printirane na INT vuv fail !!!!*/
	fclose(fop2222);

	return 0;
}