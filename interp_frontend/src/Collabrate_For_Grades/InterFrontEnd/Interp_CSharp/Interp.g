////////////////////////////////////////////////////////////////////////
// Interp.g: creates a parser for the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Deepak Goyal (dgoyal@syr.edu)
// language: antlr 3.0.1 parser generator - grammer input
////////////////////////////////////////////////////////////////////////

grammar Interp;

options {
  language = 'CSharp';
  output=AST;
} 

@parser::header {
using System.Collections.Generic;
}

@lexer::header {
using System.Collections.Generic;
}

/*
 * Parser Rules
 */
program returns [List<Element> ret]
@init {
  retval.ret = new List<Element>();
}
  : (expr {retval.ret.Add($expr.ret); } )+;
expr returns [Element ret]
  : assignment {retval.ret = $assignment.ret;}
  | scalarvardec { retval.ret = $scalarvardec.ret;}
  | vectorvardec { retval.ret = $vectorvardec.ret;}
  | matrixvardec { retval.ret = $matrixvardec.ret;}
  | deletionofvar { retval.ret = $deletionofvar.ret;}
  | structdec {retval.ret = $structdec.ret;}
  | structobjdec { retval.ret = $structobjdec.ret;}
  | print { retval.ret = $print.ret; };

assignment returns [AssignmentOperationElement ret]
@init {
  retval.ret = new AssignmentOperationElement();
}
  : (variable {retval.ret.setLhs($variable.ret); }
  | structassign {retval.ret.setStructLhs($structassign.ret);})
  ASSIGNMENT 
    (var_int_or_double_literal {retval.ret.setRhs($var_int_or_double_literal.ret); }
    | addition {retval.ret.setRhs($addition.ret);}
    | multiplication {retval.ret.setRhs($multiplication.ret);}
    ) END_OF_STATEMENT;

var_int_or_double_literal returns [Element ret]
  :  (variable { retval.ret = $variable.ret; } 
  |   int_literal {retval.ret = $int_literal.ret; }
  |   double_literal {retval.ret = $double_literal.ret;});
  
int_literal returns [IntegerElement ret]
@init {
  retval.ret = new IntegerElement();
}
  : el1=INT_LITERAL { retval.ret.setText($el1.text); };

double_literal returns [DoubleElement ret]
@init {
	retval.ret = new DoubleElement();
	}
	://(el1=INT_LITERAL {retval.ret.setText($el1.text);}
	 el1=DOUBLE_LITERAL {retval.ret.setText($el1.text);};
	  
variable returns [VariableElement ret]
@init {
  retval.ret = new VariableElement();
}
  : VARIABLE {retval.ret.setText($VARIABLE.text); };   

matrixvardec returns [MatrixVariableDeclaration ret]
@init {
	retval.ret = new MatrixVariableDeclaration();
	}
	:('Matrix' '<' VARTYPE { retval.ret.setType($VARTYPE.text);}'>' '['el1=int_literal { retval.ret.setRow($el1.ret);}']'
	'[' el2=int_literal { retval.ret.setColumn($el2.ret);}']'
	 (el3= variable { retval.ret.setVar($el3.ret);})
	 ASSIGNMENT
	 '['((el4=int_literal {retval.ret.addValue($el4.ret);}|el5=double_literal {retval.ret.addValue($el5.ret);})
	 (','el6=int_literal {retval.ret.addValue($el6.ret);}|','el7=double_literal {retval.ret.addValue($el7.ret);})*)']'{retval.ret.setValue();})
	 END_OF_STATEMENT;

vectorvardec returns [VectorVariableDeclaration ret]
@init {
	retval.ret = new VectorVariableDeclaration();
	}
	:('Vector' '<' VARTYPE { retval.ret.setType($VARTYPE.text);}'>' '['el1=int_literal {retval.ret.setRange($el1.ret);}']'
	 el2=variable {retval.ret.setText($el2.ret);} 
	 ASSIGNMENT 
	 '['((el3=int_literal {retval.ret.addValue($el3.ret);}|el4=double_literal {retval.ret.addValue($el4.ret);})
	 (','el5=int_literal {retval.ret.addValue($el5.ret);}|','el6=double_literal {retval.ret.addValue($el6.ret);})*)']'{retval.ret.setValue();})
	 END_OF_STATEMENT;
	 		  
addition returns [AdditionOperationElement ret]
@init {
  retval.ret = new AdditionOperationElement();
}
  : el1=var_int_or_double_literal { retval.ret.setLhs($el1.ret); } 
    '+' 
    el2=var_int_or_double_literal { retval.ret.setRhs($el2.ret); };
    
multiplication returns [MultiplicationOperationElement ret]
@init {
  retval.ret = new MultiplicationOperationElement();
}
  : el1=var_int_or_double_literal { retval.ret.setLhs($el1.ret); } 
    '*' 
    el2=var_int_or_double_literal { retval.ret.setRhs($el2.ret); };    
    
structdec returns [StructDeclaration ret]
@init {
	retval.ret = new StructDeclaration();
	}
	: ('Struct' variable { retval.ret.setName($variable.ret);}
	'{' (el1=scalarvardec { retval.ret.setVarType($el1.ret);})+
	'}')END_OF_STATEMENT; 

scalarvardec returns [ScalarVariableDeclaration ret]
@init {
	retval.ret = new ScalarVariableDeclaration();
	}	
	:((VARTYPE { retval.ret.setType($VARTYPE.text);}
	| STRINGTYPE { retval.ret.setType($STRINGTYPE.text);}) 
	variable { retval.ret.setVar($variable.ret);})END_OF_STATEMENT;
	
structobjdec returns [StructObjectDeclaration ret]
@init {
	retval.ret = new StructObjectDeclaration();
	}
	: (el1=variable { retval.ret.setStructName($el1.ret);}
	  el2=variable { retval.ret.setObjName($el2.ret);})
	  END_OF_STATEMENT;
	  
structassign returns [StructAssignDeclaration ret]
@init {
	retval.ret = new StructAssignDeclaration();
	}
	:(el1=variable {retval.ret.setName($el1.ret);}'.'el2=variable {retval.ret.setObj($el2.ret);});

deletionofvar returns [DeleteVariable ret]
@init {
	retval.ret = new DeleteVariable();
	}
	:('delete' el1=variable { retval.ret.setVar($el1.ret);})END_OF_STATEMENT;
			  	
print returns [PrintOperationElement ret]
@init {
  retval.ret = new PrintOperationElement();
}
  : 'print' var_int_or_double_literal {retval.ret.setChildElement($var_int_or_double_literal.ret); }
    END_OF_STATEMENT; 

/*
 * Lexer Rules
 */

END_OF_STATEMENT: ';';
ASSIGNMENT: '=';
PLUS: '+';
MULTIPLY: '*';
//OPENBRACKET	:	'(';
//CLOSEBRACKET :	')';
//SQUAREOPENBRACKET :	'[';
//SQUARECLOSEBRACKET :	']';
VARTYPE	:	('int'|'double');
STRINGTYPE	:	('String');
VARIABLE: ('a'..'z' | 'A'..'Z' )+;
INT_LITERAL: ('0'..'9')+;
DOUBLE_LITERAL:(INT_LITERAL'.'INT_LITERAL)+;	
//ALPHA	:	(VARIABLE|INT_LITERAL | '('..')')+;
WHITESPACE : (' ' | '\t' | '\n' | '\r' )+ {$channel = HIDDEN; } ;

