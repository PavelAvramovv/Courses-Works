#pragma warning(disable : 4996)
#include <stdio.h>
#include <stdlib.h> // For exit() function
#include <string.h>

// Vrushta true ako e Opertor
bool isOperator(char ch)
{
	if (ch == '+' || ch == '-' || ch == '*' ||
		ch == '/' || ch == '>' || ch == '<' ||
		ch == '=')
		return (true);
	return (false);
}

void parse(char* str)
{
	int left = 0, right = 0;
	int len = strlen(str);

	while (right <= len && left <= right) {
		
			if (isOperator(str[right]) == true)
				printf("'%c' IS AN OPERATOR\n", str[right]);

			right++;
			left = right;
		}
		
	return;
}


char* screen(char c[])/*Funciq za text menu*/
{
	strcat(c, "[1]-Chetene na programa i zapis\n[2]-Chetene na programa i izvejdane na rezultata 2\n[3]-Chetene na programa i izvejdane na ekrana\n[4]-Neshto si...\n[5]-Exit");
	return c;
}
int main()
{
	char filename[100];
	char c;
	int command = 0;
	char b[100] ="";
	int line_count = 0, n_o_c_l = 0, n_o_n_b_l = 0, n_o_b_l = 0, n_e_c = 0;
	char  arrr[100];// = "asd.txt";/*In progress insert scanf*/
	while (command != 5)
	{
	//	screen(b);
		printf("[1]-Chetene na programa ot fail i zapis na rezultata vuv fail\n[2]-Chetene na programa ot fail i izvejdane na rezultata na ekrana\n[3]-Chetene na programa ot klaviatura i izvejdane vuv fail\n[4]-Chetene na programa ot klaviaturata i izvejdane na ekrana\n[5]-Exit");
		printf("%s\n", b);
		printf("Izberete komanda:");
		scanf("%d", &command);
	//	printf("Vashata komanda e %d\n", command);/*Just for debuging*/
		switch (command)
		{
			/*Chete na programa ot fail i zapis na rezultata*/
		case 1: 
			
			FILE *fp2;
			char ch2;

			printf("Ime na fail:");
			scanf("%s", arrr);
			
			fp2 = fopen(arrr, "r");

			while ((ch2 = fgetc(fp2)) != EOF)
			{
				if (ch2 == '\n')
				{
					line_count++;
				}
				if (ch2 == '\n')
				{
					if ((ch2 = fgetc(fp2)) == '\n')
					{
						fseek(fp2, -1, 1);
						n_o_b_l++;
					}
				}
				if (ch2 == ';')
				{
					if ((ch2 = fgetc(fp2)) == '\n')
					{
						fseek(fp2, -1, 1);
						n_e_c++;
					}
				}
			}
			fseek(fp2, 0, 0);
			while ((ch2 = fgetc(fp2)) != EOF)
			{
				if (ch2 == '/')
				{
					if ((ch2 = fgetc(fp2)) == '/')
					{
						n_o_c_l++;
					}
				}
			}

			printf("Total no of blank lines: %d\n", n_o_b_l);
			/*Zapisvane na rezultata vuv faila ! */
			char  arrr2[100];
			printf("Ime na fail za zapis na rezultata:");
			scanf("%s", arrr2);
			FILE* fop2222;
			fop2222 = fopen(arrr2, "w");
			//printf("%d", n_o_b_l);/*Just debuging*/
			fprintf(fop2222, "Prazni redove:");
			fprintf(fop2222, "%d", n_o_b_l);/*Printirane na INT vuv fail !!!!*/
			
			fclose(fop2222);
			printf("Uspeshno zapisani stoinosti !");
			break;
			/*Chete na programa ot fail i izvejdane na rezultata na ekrana*/
		case 2:
		
			FILE *fp1;
			char ch;
			printf("Ime na fail:");
			scanf("%s", arrr);
			fp1 = fopen(arrr, "r");

			while ((ch = fgetc(fp1)) != EOF)
			{
				if (ch == '\n')
				{
					line_count++;
				}
				if (ch == '\n')
				{
					if ((ch = fgetc(fp1)) == '\n')
					{
						fseek(fp1, -1, 1);
						n_o_b_l++;
					}
				}
				if (ch == ';')
				{
					if ((ch = fgetc(fp1)) == '\n')
					{
						fseek(fp1, -1, 1);
						n_e_c++;
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
						n_o_c_l++;
					}
				}
			}
		
			printf("Total no of blank lines: %d\n", n_o_b_l);
			break;
			/*Chete na programa ot klaviatura i izvejdane vuv fail zadaden ot potrebitelq  */
		case 3:
			char content[100];
			FILE *fop;

			printf("File za pisane: \n");
			scanf("%s", filename);
			fop = fopen(filename, "w");
			scanf("%s", content);
			
			printf("Content on File: %s\n", content);/*Just for debug*/
			fputs(content, fop);
			fclose(fop);
			
			break;
			/*Chetene na programa ot (fail) KLAVIATURA i izvejdane na ekrana*/
		case 4:

			char commandProgram[100];
			printf("Vuvedete vashtata programa:");
			scanf("%s", commandProgram);
			printf("%s",commandProgram);
			parse(content);
			break;
		}
	}
	
	return 0;
}