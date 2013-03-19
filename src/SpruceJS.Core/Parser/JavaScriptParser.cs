// $ANTLR 3.3 Nov 30, 2010 12:45:30 C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g 2013-02-20 22:53:22

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;

using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  Sudio.NET.Parser 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class JavaScriptParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "LT", "Identifier", "StringLiteral", "NumericLiteral", "DoubleStringCharacter", "SingleStringCharacter", "EscapeSequence", "CharacterEscapeSequence", "HexEscapeSequence", "UnicodeEscapeSequence", "SingleEscapeCharacter", "NonEscapeCharacter", "EscapeCharacter", "DecimalDigit", "HexDigit", "DecimalLiteral", "HexIntegerLiteral", "ExponentPart", "IdentifierStart", "IdentifierPart", "UnicodeLetter", "UnicodeDigit", "UnicodeConnectorPunctuation", "UnicodeCombiningMark", "Comment", "LineComment", "WhiteSpace", "'function'", "'('", "','", "')'", "'{'", "'}'", "'var'", "';'", "'='", "'if'", "'else'", "'do'", "'while'", "'for'", "'in'", "'continue'", "'break'", "'return'", "'with'", "':'", "'switch'", "'case'", "'default'", "'throw'", "'try'", "'catch'", "'finally'", "'new'", "'['", "']'", "'.'", "'*='", "'/='", "'%='", "'+='", "'-='", "'<<='", "'>>='", "'>>>='", "'&='", "'^='", "'|='", "'?'", "'||'", "'&&'", "'|'", "'^'", "'&'", "'=='", "'!='", "'==='", "'!=='", "'<'", "'>'", "'<='", "'>='", "'instanceof'", "'<<'", "'>>'", "'>>>'", "'+'", "'-'", "'*'", "'/'", "'%'", "'delete'", "'void'", "'typeof'", "'++'", "'--'", "'~'", "'!'", "'this'", "'null'", "'true'", "'false'"
	};
	public const int EOF=-1;
	public const int T__31=31;
	public const int T__32=32;
	public const int T__33=33;
	public const int T__34=34;
	public const int T__35=35;
	public const int T__36=36;
	public const int T__37=37;
	public const int T__38=38;
	public const int T__39=39;
	public const int T__40=40;
	public const int T__41=41;
	public const int T__42=42;
	public const int T__43=43;
	public const int T__44=44;
	public const int T__45=45;
	public const int T__46=46;
	public const int T__47=47;
	public const int T__48=48;
	public const int T__49=49;
	public const int T__50=50;
	public const int T__51=51;
	public const int T__52=52;
	public const int T__53=53;
	public const int T__54=54;
	public const int T__55=55;
	public const int T__56=56;
	public const int T__57=57;
	public const int T__58=58;
	public const int T__59=59;
	public const int T__60=60;
	public const int T__61=61;
	public const int T__62=62;
	public const int T__63=63;
	public const int T__64=64;
	public const int T__65=65;
	public const int T__66=66;
	public const int T__67=67;
	public const int T__68=68;
	public const int T__69=69;
	public const int T__70=70;
	public const int T__71=71;
	public const int T__72=72;
	public const int T__73=73;
	public const int T__74=74;
	public const int T__75=75;
	public const int T__76=76;
	public const int T__77=77;
	public const int T__78=78;
	public const int T__79=79;
	public const int T__80=80;
	public const int T__81=81;
	public const int T__82=82;
	public const int T__83=83;
	public const int T__84=84;
	public const int T__85=85;
	public const int T__86=86;
	public const int T__87=87;
	public const int T__88=88;
	public const int T__89=89;
	public const int T__90=90;
	public const int T__91=91;
	public const int T__92=92;
	public const int T__93=93;
	public const int T__94=94;
	public const int T__95=95;
	public const int T__96=96;
	public const int T__97=97;
	public const int T__98=98;
	public const int T__99=99;
	public const int T__100=100;
	public const int T__101=101;
	public const int T__102=102;
	public const int T__103=103;
	public const int T__104=104;
	public const int T__105=105;
	public const int T__106=106;
	public const int LT=4;
	public const int Identifier=5;
	public const int StringLiteral=6;
	public const int NumericLiteral=7;
	public const int DoubleStringCharacter=8;
	public const int SingleStringCharacter=9;
	public const int EscapeSequence=10;
	public const int CharacterEscapeSequence=11;
	public const int HexEscapeSequence=12;
	public const int UnicodeEscapeSequence=13;
	public const int SingleEscapeCharacter=14;
	public const int NonEscapeCharacter=15;
	public const int EscapeCharacter=16;
	public const int DecimalDigit=17;
	public const int HexDigit=18;
	public const int DecimalLiteral=19;
	public const int HexIntegerLiteral=20;
	public const int ExponentPart=21;
	public const int IdentifierStart=22;
	public const int IdentifierPart=23;
	public const int UnicodeLetter=24;
	public const int UnicodeDigit=25;
	public const int UnicodeConnectorPunctuation=26;
	public const int UnicodeCombiningMark=27;
	public const int Comment=28;
	public const int LineComment=29;
	public const int WhiteSpace=30;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, true, false, false, false, true, false, 
				false, false, false, false, false, false, false, false, false, false, 
				true, true, false, false, false, false, false, false, false, false, 
				false, false, false, true, false, true, false, false, false, false, 
				false, false, false, false, false, true, true, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, true, false, false, 
				true, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				true, false, false, true, true, false, true, false, false, false, false, 
				true, false, false, false, true, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, true, false, false, false, false, false, false, false, 
				false, true, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, , , , , , , , , , , , , false, false, 
				, , , , , , , , , , , , , false, false, , , , , , , , , , , , , , , 
				, , , , , , , , , , , , , , , , , , , , , , , , , , , , , , false, false, 
				, , , , , , , 
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public JavaScriptParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public JavaScriptParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[380+1];

		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return JavaScriptParser.tokenNames; } }
	public override string GrammarFileName { get { return "C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:18:1: program : ( LT )* sourceElements ( LT )* EOF ;
	[GrammarRule("program")]
	public JavaScriptParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 1);
		TraceIn("program", 1);
		JavaScriptParser.program_return retval = new JavaScriptParser.program_return();
		retval.Start = (IToken)input.LT(1);
		int program_StartIndex = input.Index;
		object root_0 = null;

		IToken LT1=null;
		IToken LT3=null;
		IToken EOF4=null;
		JavaScriptParser.sourceElements_return sourceElements2 = default(JavaScriptParser.sourceElements_return);

		object LT1_tree=null;
		object LT3_tree=null;
		object EOF4_tree=null;

		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(18, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:19:2: ( ( LT )* sourceElements ( LT )* EOF )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:19:4: ( LT )* sourceElements ( LT )* EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(19, 6);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:19:6: ( LT )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if ((LA1_0==LT))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(19, 6);
					LT1=(IToken)Match(input,LT,Follow._LT_in_program49); if (state.failed) return retval;

					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }

			DebugLocation(19, 9);
			PushFollow(Follow._sourceElements_in_program53);
			sourceElements2=sourceElements();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sourceElements2.Tree);
			DebugLocation(19, 26);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:19:26: ( LT )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0==LT))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(19, 26);
					LT3=(IToken)Match(input,LT,Follow._LT_in_program55); if (state.failed) return retval;

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }

			DebugLocation(19, 32);
			EOF4=(IToken)Match(input,EOF,Follow._EOF_in_program59); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("program", 1);
			LeaveRule("program", 1);
			Leave_program();
			if (state.backtracking > 0) { Memoize(input, 1, program_StartIndex); }
		}
		DebugLocation(20, 1);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return retval;

	}
	// $ANTLR end "program"

	public class sourceElements_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_sourceElements();
	partial void Leave_sourceElements();

	// $ANTLR start "sourceElements"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:22:1: sourceElements : sourceElement ( ( LT )* sourceElement )* ;
	[GrammarRule("sourceElements")]
	private JavaScriptParser.sourceElements_return sourceElements()
	{
		Enter_sourceElements();
		EnterRule("sourceElements", 2);
		TraceIn("sourceElements", 2);
		JavaScriptParser.sourceElements_return retval = new JavaScriptParser.sourceElements_return();
		retval.Start = (IToken)input.LT(1);
		int sourceElements_StartIndex = input.Index;
		object root_0 = null;

		IToken LT6=null;
		JavaScriptParser.sourceElement_return sourceElement5 = default(JavaScriptParser.sourceElement_return);
		JavaScriptParser.sourceElement_return sourceElement7 = default(JavaScriptParser.sourceElement_return);

		object LT6_tree=null;

		try { DebugEnterRule(GrammarFileName, "sourceElements");
		DebugLocation(22, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:23:2: ( sourceElement ( ( LT )* sourceElement )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:23:4: sourceElement ( ( LT )* sourceElement )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(23, 4);
			PushFollow(Follow._sourceElement_in_sourceElements72);
			sourceElement5=sourceElement();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sourceElement5.Tree);
			DebugLocation(23, 18);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:23:18: ( ( LT )* sourceElement )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				try
				{
					alt4 = dfa4.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:23:19: ( LT )* sourceElement
					{
					DebugLocation(23, 21);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:23:21: ( LT )*
					try { DebugEnterSubRule(3);
					while (true)
					{
						int alt3=2;
						try { DebugEnterDecision(3, decisionCanBacktrack[3]);
						int LA3_0 = input.LA(1);

						if ((LA3_0==LT))
						{
							alt3=1;
						}


						} finally { DebugExitDecision(3); }
						switch ( alt3 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(23, 21);
							LT6=(IToken)Match(input,LT,Follow._LT_in_sourceElements75); if (state.failed) return retval;

							}
							break;

						default:
							goto loop3;
						}
					}

					loop3:
						;

					} finally { DebugExitSubRule(3); }

					DebugLocation(23, 24);
					PushFollow(Follow._sourceElement_in_sourceElements79);
					sourceElement7=sourceElement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sourceElement7.Tree);

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("sourceElements", 2);
			LeaveRule("sourceElements", 2);
			Leave_sourceElements();
			if (state.backtracking > 0) { Memoize(input, 2, sourceElements_StartIndex); }
		}
		DebugLocation(24, 1);
		} finally { DebugExitRule(GrammarFileName, "sourceElements"); }
		return retval;

	}
	// $ANTLR end "sourceElements"

	public class sourceElement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_sourceElement();
	partial void Leave_sourceElement();

	// $ANTLR start "sourceElement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:26:1: sourceElement : ( functionDeclaration | statement );
	[GrammarRule("sourceElement")]
	private JavaScriptParser.sourceElement_return sourceElement()
	{
		Enter_sourceElement();
		EnterRule("sourceElement", 3);
		TraceIn("sourceElement", 3);
		JavaScriptParser.sourceElement_return retval = new JavaScriptParser.sourceElement_return();
		retval.Start = (IToken)input.LT(1);
		int sourceElement_StartIndex = input.Index;
		object root_0 = null;

		JavaScriptParser.functionDeclaration_return functionDeclaration8 = default(JavaScriptParser.functionDeclaration_return);
		JavaScriptParser.statement_return statement9 = default(JavaScriptParser.statement_return);


		try { DebugEnterRule(GrammarFileName, "sourceElement");
		DebugLocation(26, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:27:2: ( functionDeclaration | statement )
			int alt5=2;
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			try
			{
				alt5 = dfa5.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:27:4: functionDeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(27, 4);
				PushFollow(Follow._functionDeclaration_in_sourceElement93);
				functionDeclaration8=functionDeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionDeclaration8.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:28:4: statement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(28, 4);
				PushFollow(Follow._statement_in_sourceElement98);
				statement9=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement9.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("sourceElement", 3);
			LeaveRule("sourceElement", 3);
			Leave_sourceElement();
			if (state.backtracking > 0) { Memoize(input, 3, sourceElement_StartIndex); }
		}
		DebugLocation(29, 1);
		} finally { DebugExitRule(GrammarFileName, "sourceElement"); }
		return retval;

	}
	// $ANTLR end "sourceElement"

	public class functionDeclaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_functionDeclaration();
	partial void Leave_functionDeclaration();

	// $ANTLR start "functionDeclaration"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:32:1: functionDeclaration : 'function' ( LT )* Identifier ( LT )* formalParameterList ( LT )* functionBody ;
	[GrammarRule("functionDeclaration")]
	private JavaScriptParser.functionDeclaration_return functionDeclaration()
	{
		Enter_functionDeclaration();
		EnterRule("functionDeclaration", 4);
		TraceIn("functionDeclaration", 4);
		JavaScriptParser.functionDeclaration_return retval = new JavaScriptParser.functionDeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int functionDeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal10=null;
		IToken LT11=null;
		IToken Identifier12=null;
		IToken LT13=null;
		IToken LT15=null;
		JavaScriptParser.formalParameterList_return formalParameterList14 = default(JavaScriptParser.formalParameterList_return);
		JavaScriptParser.functionBody_return functionBody16 = default(JavaScriptParser.functionBody_return);

		object string_literal10_tree=null;
		object LT11_tree=null;
		object Identifier12_tree=null;
		object LT13_tree=null;
		object LT15_tree=null;

		try { DebugEnterRule(GrammarFileName, "functionDeclaration");
		DebugLocation(32, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:33:2: ( 'function' ( LT )* Identifier ( LT )* formalParameterList ( LT )* functionBody )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:33:4: 'function' ( LT )* Identifier ( LT )* formalParameterList ( LT )* functionBody
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(33, 4);
			string_literal10=(IToken)Match(input,31,Follow._31_in_functionDeclaration111); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal10_tree = (object)adaptor.Create(string_literal10);
			adaptor.AddChild(root_0, string_literal10_tree);
			}
			DebugLocation(33, 17);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:33:17: ( LT )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if ((LA6_0==LT))
				{
					alt6=1;
				}


				} finally { DebugExitDecision(6); }
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(33, 17);
					LT11=(IToken)Match(input,LT,Follow._LT_in_functionDeclaration113); if (state.failed) return retval;

					}
					break;

				default:
					goto loop6;
				}
			}

			loop6:
				;

			} finally { DebugExitSubRule(6); }

			DebugLocation(33, 20);
			Identifier12=(IToken)Match(input,Identifier,Follow._Identifier_in_functionDeclaration117); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			Identifier12_tree = (object)adaptor.Create(Identifier12);
			adaptor.AddChild(root_0, Identifier12_tree);
			}
			DebugLocation(33, 33);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:33:33: ( LT )*
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if ((LA7_0==LT))
				{
					alt7=1;
				}


				} finally { DebugExitDecision(7); }
				switch ( alt7 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(33, 33);
					LT13=(IToken)Match(input,LT,Follow._LT_in_functionDeclaration119); if (state.failed) return retval;

					}
					break;

				default:
					goto loop7;
				}
			}

			loop7:
				;

			} finally { DebugExitSubRule(7); }

			DebugLocation(33, 36);
			PushFollow(Follow._formalParameterList_in_functionDeclaration123);
			formalParameterList14=formalParameterList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameterList14.Tree);
			DebugLocation(33, 58);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:33:58: ( LT )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if ((LA8_0==LT))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(33, 58);
					LT15=(IToken)Match(input,LT,Follow._LT_in_functionDeclaration125); if (state.failed) return retval;

					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }

			DebugLocation(33, 61);
			PushFollow(Follow._functionBody_in_functionDeclaration129);
			functionBody16=functionBody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionBody16.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("functionDeclaration", 4);
			LeaveRule("functionDeclaration", 4);
			Leave_functionDeclaration();
			if (state.backtracking > 0) { Memoize(input, 4, functionDeclaration_StartIndex); }
		}
		DebugLocation(34, 1);
		} finally { DebugExitRule(GrammarFileName, "functionDeclaration"); }
		return retval;

	}
	// $ANTLR end "functionDeclaration"

	public class functionExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_functionExpression();
	partial void Leave_functionExpression();

	// $ANTLR start "functionExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:36:1: functionExpression : 'function' ( LT )* ( Identifier )? ( LT )* formalParameterList ( LT )* functionBody ;
	[GrammarRule("functionExpression")]
	private JavaScriptParser.functionExpression_return functionExpression()
	{
		Enter_functionExpression();
		EnterRule("functionExpression", 5);
		TraceIn("functionExpression", 5);
		JavaScriptParser.functionExpression_return retval = new JavaScriptParser.functionExpression_return();
		retval.Start = (IToken)input.LT(1);
		int functionExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal17=null;
		IToken LT18=null;
		IToken Identifier19=null;
		IToken LT20=null;
		IToken LT22=null;
		JavaScriptParser.formalParameterList_return formalParameterList21 = default(JavaScriptParser.formalParameterList_return);
		JavaScriptParser.functionBody_return functionBody23 = default(JavaScriptParser.functionBody_return);

		object string_literal17_tree=null;
		object LT18_tree=null;
		object Identifier19_tree=null;
		object LT20_tree=null;
		object LT22_tree=null;

		try { DebugEnterRule(GrammarFileName, "functionExpression");
		DebugLocation(36, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:37:2: ( 'function' ( LT )* ( Identifier )? ( LT )* formalParameterList ( LT )* functionBody )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:37:4: 'function' ( LT )* ( Identifier )? ( LT )* formalParameterList ( LT )* functionBody
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(37, 4);
			string_literal17=(IToken)Match(input,31,Follow._31_in_functionExpression141); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal17_tree = (object)adaptor.Create(string_literal17);
			adaptor.AddChild(root_0, string_literal17_tree);
			}
			DebugLocation(37, 17);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:37:17: ( LT )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if ((LA9_0==LT))
				{
					int LA9_2 = input.LA(2);

					if ((EvaluatePredicate(synpred9_JavaScript_fragment)))
					{
						alt9=1;
					}


				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(37, 17);
					LT18=(IToken)Match(input,LT,Follow._LT_in_functionExpression143); if (state.failed) return retval;

					}
					break;

				default:
					goto loop9;
				}
			}

			loop9:
				;

			} finally { DebugExitSubRule(9); }

			DebugLocation(37, 20);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:37:20: ( Identifier )?
			int alt10=2;
			try { DebugEnterSubRule(10);
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			int LA10_0 = input.LA(1);

			if ((LA10_0==Identifier))
			{
				alt10=1;
			}
			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: Identifier
				{
				DebugLocation(37, 20);
				Identifier19=(IToken)Match(input,Identifier,Follow._Identifier_in_functionExpression147); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				Identifier19_tree = (object)adaptor.Create(Identifier19);
				adaptor.AddChild(root_0, Identifier19_tree);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(10); }

			DebugLocation(37, 34);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:37:34: ( LT )*
			try { DebugEnterSubRule(11);
			while (true)
			{
				int alt11=2;
				try { DebugEnterDecision(11, decisionCanBacktrack[11]);
				int LA11_0 = input.LA(1);

				if ((LA11_0==LT))
				{
					alt11=1;
				}


				} finally { DebugExitDecision(11); }
				switch ( alt11 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(37, 34);
					LT20=(IToken)Match(input,LT,Follow._LT_in_functionExpression150); if (state.failed) return retval;

					}
					break;

				default:
					goto loop11;
				}
			}

			loop11:
				;

			} finally { DebugExitSubRule(11); }

			DebugLocation(37, 37);
			PushFollow(Follow._formalParameterList_in_functionExpression154);
			formalParameterList21=formalParameterList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameterList21.Tree);
			DebugLocation(37, 59);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:37:59: ( LT )*
			try { DebugEnterSubRule(12);
			while (true)
			{
				int alt12=2;
				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
				int LA12_0 = input.LA(1);

				if ((LA12_0==LT))
				{
					alt12=1;
				}


				} finally { DebugExitDecision(12); }
				switch ( alt12 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(37, 59);
					LT22=(IToken)Match(input,LT,Follow._LT_in_functionExpression156); if (state.failed) return retval;

					}
					break;

				default:
					goto loop12;
				}
			}

			loop12:
				;

			} finally { DebugExitSubRule(12); }

			DebugLocation(37, 62);
			PushFollow(Follow._functionBody_in_functionExpression160);
			functionBody23=functionBody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionBody23.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("functionExpression", 5);
			LeaveRule("functionExpression", 5);
			Leave_functionExpression();
			if (state.backtracking > 0) { Memoize(input, 5, functionExpression_StartIndex); }
		}
		DebugLocation(38, 1);
		} finally { DebugExitRule(GrammarFileName, "functionExpression"); }
		return retval;

	}
	// $ANTLR end "functionExpression"

	public class formalParameterList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_formalParameterList();
	partial void Leave_formalParameterList();

	// $ANTLR start "formalParameterList"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:40:1: formalParameterList : '(' ( ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )* )? ( LT )* ')' ;
	[GrammarRule("formalParameterList")]
	private JavaScriptParser.formalParameterList_return formalParameterList()
	{
		Enter_formalParameterList();
		EnterRule("formalParameterList", 6);
		TraceIn("formalParameterList", 6);
		JavaScriptParser.formalParameterList_return retval = new JavaScriptParser.formalParameterList_return();
		retval.Start = (IToken)input.LT(1);
		int formalParameterList_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal24=null;
		IToken LT25=null;
		IToken Identifier26=null;
		IToken LT27=null;
		IToken char_literal28=null;
		IToken LT29=null;
		IToken Identifier30=null;
		IToken LT31=null;
		IToken char_literal32=null;

		object char_literal24_tree=null;
		object LT25_tree=null;
		object Identifier26_tree=null;
		object LT27_tree=null;
		object char_literal28_tree=null;
		object LT29_tree=null;
		object Identifier30_tree=null;
		object LT31_tree=null;
		object char_literal32_tree=null;

		try { DebugEnterRule(GrammarFileName, "formalParameterList");
		DebugLocation(40, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:41:2: ( '(' ( ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )* )? ( LT )* ')' )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:41:4: '(' ( ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )* )? ( LT )* ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(41, 4);
			char_literal24=(IToken)Match(input,32,Follow._32_in_formalParameterList172); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal24_tree = (object)adaptor.Create(char_literal24);
			adaptor.AddChild(root_0, char_literal24_tree);
			}
			DebugLocation(41, 8);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:41:8: ( ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )* )?
			int alt17=2;
			try { DebugEnterSubRule(17);
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			try
			{
				alt17 = dfa17.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(17); }
			switch (alt17)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:41:9: ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )*
				{
				DebugLocation(41, 11);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:41:11: ( LT )*
				try { DebugEnterSubRule(13);
				while (true)
				{
					int alt13=2;
					try { DebugEnterDecision(13, decisionCanBacktrack[13]);
					int LA13_0 = input.LA(1);

					if ((LA13_0==LT))
					{
						alt13=1;
					}


					} finally { DebugExitDecision(13); }
					switch ( alt13 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(41, 11);
						LT25=(IToken)Match(input,LT,Follow._LT_in_formalParameterList175); if (state.failed) return retval;

						}
						break;

					default:
						goto loop13;
					}
				}

				loop13:
					;

				} finally { DebugExitSubRule(13); }

				DebugLocation(41, 14);
				Identifier26=(IToken)Match(input,Identifier,Follow._Identifier_in_formalParameterList179); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				Identifier26_tree = (object)adaptor.Create(Identifier26);
				adaptor.AddChild(root_0, Identifier26_tree);
				}
				DebugLocation(41, 25);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:41:25: ( ( LT )* ',' ( LT )* Identifier )*
				try { DebugEnterSubRule(16);
				while (true)
				{
					int alt16=2;
					try { DebugEnterDecision(16, decisionCanBacktrack[16]);
					try
					{
						alt16 = dfa16.Predict(input);
					}
					catch (NoViableAltException nvae)
					{
						DebugRecognitionException(nvae);
						throw;
					}
					} finally { DebugExitDecision(16); }
					switch ( alt16 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:41:26: ( LT )* ',' ( LT )* Identifier
						{
						DebugLocation(41, 28);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:41:28: ( LT )*
						try { DebugEnterSubRule(14);
						while (true)
						{
							int alt14=2;
							try { DebugEnterDecision(14, decisionCanBacktrack[14]);
							int LA14_0 = input.LA(1);

							if ((LA14_0==LT))
							{
								alt14=1;
							}


							} finally { DebugExitDecision(14); }
							switch ( alt14 )
							{
							case 1:
								DebugEnterAlt(1);
								// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
								{
								DebugLocation(41, 28);
								LT27=(IToken)Match(input,LT,Follow._LT_in_formalParameterList182); if (state.failed) return retval;

								}
								break;

							default:
								goto loop14;
							}
						}

						loop14:
							;

						} finally { DebugExitSubRule(14); }

						DebugLocation(41, 31);
						char_literal28=(IToken)Match(input,33,Follow._33_in_formalParameterList186); if (state.failed) return retval;
						if ( state.backtracking==0 ) {
						char_literal28_tree = (object)adaptor.Create(char_literal28);
						adaptor.AddChild(root_0, char_literal28_tree);
						}
						DebugLocation(41, 37);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:41:37: ( LT )*
						try { DebugEnterSubRule(15);
						while (true)
						{
							int alt15=2;
							try { DebugEnterDecision(15, decisionCanBacktrack[15]);
							int LA15_0 = input.LA(1);

							if ((LA15_0==LT))
							{
								alt15=1;
							}


							} finally { DebugExitDecision(15); }
							switch ( alt15 )
							{
							case 1:
								DebugEnterAlt(1);
								// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
								{
								DebugLocation(41, 37);
								LT29=(IToken)Match(input,LT,Follow._LT_in_formalParameterList188); if (state.failed) return retval;

								}
								break;

							default:
								goto loop15;
							}
						}

						loop15:
							;

						} finally { DebugExitSubRule(15); }

						DebugLocation(41, 40);
						Identifier30=(IToken)Match(input,Identifier,Follow._Identifier_in_formalParameterList192); if (state.failed) return retval;
						if ( state.backtracking==0 ) {
						Identifier30_tree = (object)adaptor.Create(Identifier30);
						adaptor.AddChild(root_0, Identifier30_tree);
						}

						}
						break;

					default:
						goto loop16;
					}
				}

				loop16:
					;

				} finally { DebugExitSubRule(16); }


				}
				break;

			}
			} finally { DebugExitSubRule(17); }

			DebugLocation(41, 57);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:41:57: ( LT )*
			try { DebugEnterSubRule(18);
			while (true)
			{
				int alt18=2;
				try { DebugEnterDecision(18, decisionCanBacktrack[18]);
				int LA18_0 = input.LA(1);

				if ((LA18_0==LT))
				{
					alt18=1;
				}


				} finally { DebugExitDecision(18); }
				switch ( alt18 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(41, 57);
					LT31=(IToken)Match(input,LT,Follow._LT_in_formalParameterList198); if (state.failed) return retval;

					}
					break;

				default:
					goto loop18;
				}
			}

			loop18:
				;

			} finally { DebugExitSubRule(18); }

			DebugLocation(41, 60);
			char_literal32=(IToken)Match(input,34,Follow._34_in_formalParameterList202); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal32_tree = (object)adaptor.Create(char_literal32);
			adaptor.AddChild(root_0, char_literal32_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("formalParameterList", 6);
			LeaveRule("formalParameterList", 6);
			Leave_formalParameterList();
			if (state.backtracking > 0) { Memoize(input, 6, formalParameterList_StartIndex); }
		}
		DebugLocation(42, 1);
		} finally { DebugExitRule(GrammarFileName, "formalParameterList"); }
		return retval;

	}
	// $ANTLR end "formalParameterList"

	public class functionBody_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_functionBody();
	partial void Leave_functionBody();

	// $ANTLR start "functionBody"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:44:1: functionBody : '{' ( LT )* sourceElements ( LT )* '}' ;
	[GrammarRule("functionBody")]
	private JavaScriptParser.functionBody_return functionBody()
	{
		Enter_functionBody();
		EnterRule("functionBody", 7);
		TraceIn("functionBody", 7);
		JavaScriptParser.functionBody_return retval = new JavaScriptParser.functionBody_return();
		retval.Start = (IToken)input.LT(1);
		int functionBody_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal33=null;
		IToken LT34=null;
		IToken LT36=null;
		IToken char_literal37=null;
		JavaScriptParser.sourceElements_return sourceElements35 = default(JavaScriptParser.sourceElements_return);

		object char_literal33_tree=null;
		object LT34_tree=null;
		object LT36_tree=null;
		object char_literal37_tree=null;

		try { DebugEnterRule(GrammarFileName, "functionBody");
		DebugLocation(44, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:45:2: ( '{' ( LT )* sourceElements ( LT )* '}' )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:45:4: '{' ( LT )* sourceElements ( LT )* '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(45, 4);
			char_literal33=(IToken)Match(input,35,Follow._35_in_functionBody213); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal33_tree = (object)adaptor.Create(char_literal33);
			adaptor.AddChild(root_0, char_literal33_tree);
			}
			DebugLocation(45, 10);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:45:10: ( LT )*
			try { DebugEnterSubRule(19);
			while (true)
			{
				int alt19=2;
				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
				int LA19_0 = input.LA(1);

				if ((LA19_0==LT))
				{
					alt19=1;
				}


				} finally { DebugExitDecision(19); }
				switch ( alt19 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(45, 10);
					LT34=(IToken)Match(input,LT,Follow._LT_in_functionBody215); if (state.failed) return retval;

					}
					break;

				default:
					goto loop19;
				}
			}

			loop19:
				;

			} finally { DebugExitSubRule(19); }

			DebugLocation(45, 13);
			PushFollow(Follow._sourceElements_in_functionBody219);
			sourceElements35=sourceElements();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sourceElements35.Tree);
			DebugLocation(45, 30);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:45:30: ( LT )*
			try { DebugEnterSubRule(20);
			while (true)
			{
				int alt20=2;
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				int LA20_0 = input.LA(1);

				if ((LA20_0==LT))
				{
					alt20=1;
				}


				} finally { DebugExitDecision(20); }
				switch ( alt20 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(45, 30);
					LT36=(IToken)Match(input,LT,Follow._LT_in_functionBody221); if (state.failed) return retval;

					}
					break;

				default:
					goto loop20;
				}
			}

			loop20:
				;

			} finally { DebugExitSubRule(20); }

			DebugLocation(45, 33);
			char_literal37=(IToken)Match(input,36,Follow._36_in_functionBody225); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal37_tree = (object)adaptor.Create(char_literal37);
			adaptor.AddChild(root_0, char_literal37_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("functionBody", 7);
			LeaveRule("functionBody", 7);
			Leave_functionBody();
			if (state.backtracking > 0) { Memoize(input, 7, functionBody_StartIndex); }
		}
		DebugLocation(46, 1);
		} finally { DebugExitRule(GrammarFileName, "functionBody"); }
		return retval;

	}
	// $ANTLR end "functionBody"

	public class statement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_statement();
	partial void Leave_statement();

	// $ANTLR start "statement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:49:1: statement : ( statementBlock | variableStatement | emptyStatement | expressionStatement | ifStatement | iterationStatement | continueStatement | breakStatement | returnStatement | withStatement | labelledStatement | switchStatement | throwStatement | tryStatement );
	[GrammarRule("statement")]
	private JavaScriptParser.statement_return statement()
	{
		Enter_statement();
		EnterRule("statement", 8);
		TraceIn("statement", 8);
		JavaScriptParser.statement_return retval = new JavaScriptParser.statement_return();
		retval.Start = (IToken)input.LT(1);
		int statement_StartIndex = input.Index;
		object root_0 = null;

		JavaScriptParser.statementBlock_return statementBlock38 = default(JavaScriptParser.statementBlock_return);
		JavaScriptParser.variableStatement_return variableStatement39 = default(JavaScriptParser.variableStatement_return);
		JavaScriptParser.emptyStatement_return emptyStatement40 = default(JavaScriptParser.emptyStatement_return);
		JavaScriptParser.expressionStatement_return expressionStatement41 = default(JavaScriptParser.expressionStatement_return);
		JavaScriptParser.ifStatement_return ifStatement42 = default(JavaScriptParser.ifStatement_return);
		JavaScriptParser.iterationStatement_return iterationStatement43 = default(JavaScriptParser.iterationStatement_return);
		JavaScriptParser.continueStatement_return continueStatement44 = default(JavaScriptParser.continueStatement_return);
		JavaScriptParser.breakStatement_return breakStatement45 = default(JavaScriptParser.breakStatement_return);
		JavaScriptParser.returnStatement_return returnStatement46 = default(JavaScriptParser.returnStatement_return);
		JavaScriptParser.withStatement_return withStatement47 = default(JavaScriptParser.withStatement_return);
		JavaScriptParser.labelledStatement_return labelledStatement48 = default(JavaScriptParser.labelledStatement_return);
		JavaScriptParser.switchStatement_return switchStatement49 = default(JavaScriptParser.switchStatement_return);
		JavaScriptParser.throwStatement_return throwStatement50 = default(JavaScriptParser.throwStatement_return);
		JavaScriptParser.tryStatement_return tryStatement51 = default(JavaScriptParser.tryStatement_return);


		try { DebugEnterRule(GrammarFileName, "statement");
		DebugLocation(49, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:50:2: ( statementBlock | variableStatement | emptyStatement | expressionStatement | ifStatement | iterationStatement | continueStatement | breakStatement | returnStatement | withStatement | labelledStatement | switchStatement | throwStatement | tryStatement )
			int alt21=14;
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			try
			{
				alt21 = dfa21.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(21); }
			switch (alt21)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:50:4: statementBlock
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(50, 4);
				PushFollow(Follow._statementBlock_in_statement237);
				statementBlock38=statementBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementBlock38.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:51:4: variableStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(51, 4);
				PushFollow(Follow._variableStatement_in_statement242);
				variableStatement39=variableStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableStatement39.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:52:4: emptyStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(52, 4);
				PushFollow(Follow._emptyStatement_in_statement247);
				emptyStatement40=emptyStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, emptyStatement40.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:53:4: expressionStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(53, 4);
				PushFollow(Follow._expressionStatement_in_statement252);
				expressionStatement41=expressionStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressionStatement41.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:54:4: ifStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(54, 4);
				PushFollow(Follow._ifStatement_in_statement257);
				ifStatement42=ifStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifStatement42.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:55:4: iterationStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(55, 4);
				PushFollow(Follow._iterationStatement_in_statement262);
				iterationStatement43=iterationStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, iterationStatement43.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:56:4: continueStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(56, 4);
				PushFollow(Follow._continueStatement_in_statement267);
				continueStatement44=continueStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, continueStatement44.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:57:4: breakStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(57, 4);
				PushFollow(Follow._breakStatement_in_statement272);
				breakStatement45=breakStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, breakStatement45.Tree);

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:58:4: returnStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(58, 4);
				PushFollow(Follow._returnStatement_in_statement277);
				returnStatement46=returnStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnStatement46.Tree);

				}
				break;
			case 10:
				DebugEnterAlt(10);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:59:4: withStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(59, 4);
				PushFollow(Follow._withStatement_in_statement282);
				withStatement47=withStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, withStatement47.Tree);

				}
				break;
			case 11:
				DebugEnterAlt(11);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:60:4: labelledStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(60, 4);
				PushFollow(Follow._labelledStatement_in_statement287);
				labelledStatement48=labelledStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, labelledStatement48.Tree);

				}
				break;
			case 12:
				DebugEnterAlt(12);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:61:4: switchStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(61, 4);
				PushFollow(Follow._switchStatement_in_statement292);
				switchStatement49=switchStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, switchStatement49.Tree);

				}
				break;
			case 13:
				DebugEnterAlt(13);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:62:4: throwStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(62, 4);
				PushFollow(Follow._throwStatement_in_statement297);
				throwStatement50=throwStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, throwStatement50.Tree);

				}
				break;
			case 14:
				DebugEnterAlt(14);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:63:4: tryStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(63, 4);
				PushFollow(Follow._tryStatement_in_statement302);
				tryStatement51=tryStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tryStatement51.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("statement", 8);
			LeaveRule("statement", 8);
			Leave_statement();
			if (state.backtracking > 0) { Memoize(input, 8, statement_StartIndex); }
		}
		DebugLocation(64, 1);
		} finally { DebugExitRule(GrammarFileName, "statement"); }
		return retval;

	}
	// $ANTLR end "statement"

	public class statementBlock_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_statementBlock();
	partial void Leave_statementBlock();

	// $ANTLR start "statementBlock"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:66:1: statementBlock : '{' ( LT )* ( statementList )? ( LT )* '}' ;
	[GrammarRule("statementBlock")]
	private JavaScriptParser.statementBlock_return statementBlock()
	{
		Enter_statementBlock();
		EnterRule("statementBlock", 9);
		TraceIn("statementBlock", 9);
		JavaScriptParser.statementBlock_return retval = new JavaScriptParser.statementBlock_return();
		retval.Start = (IToken)input.LT(1);
		int statementBlock_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal52=null;
		IToken LT53=null;
		IToken LT55=null;
		IToken char_literal56=null;
		JavaScriptParser.statementList_return statementList54 = default(JavaScriptParser.statementList_return);

		object char_literal52_tree=null;
		object LT53_tree=null;
		object LT55_tree=null;
		object char_literal56_tree=null;

		try { DebugEnterRule(GrammarFileName, "statementBlock");
		DebugLocation(66, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:67:2: ( '{' ( LT )* ( statementList )? ( LT )* '}' )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:67:4: '{' ( LT )* ( statementList )? ( LT )* '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(67, 4);
			char_literal52=(IToken)Match(input,35,Follow._35_in_statementBlock314); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal52_tree = (object)adaptor.Create(char_literal52);
			adaptor.AddChild(root_0, char_literal52_tree);
			}
			DebugLocation(67, 10);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:67:10: ( LT )*
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=2;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_0 = input.LA(1);

				if ((LA22_0==LT))
				{
					int LA22_2 = input.LA(2);

					if ((EvaluatePredicate(synpred34_JavaScript_fragment)))
					{
						alt22=1;
					}


				}


				} finally { DebugExitDecision(22); }
				switch ( alt22 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(67, 10);
					LT53=(IToken)Match(input,LT,Follow._LT_in_statementBlock316); if (state.failed) return retval;

					}
					break;

				default:
					goto loop22;
				}
			}

			loop22:
				;

			} finally { DebugExitSubRule(22); }

			DebugLocation(67, 13);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:67:13: ( statementList )?
			int alt23=2;
			try { DebugEnterSubRule(23);
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if (((LA23_0>=Identifier && LA23_0<=NumericLiteral)||(LA23_0>=31 && LA23_0<=32)||LA23_0==35||(LA23_0>=37 && LA23_0<=38)||LA23_0==40||(LA23_0>=42 && LA23_0<=44)||(LA23_0>=46 && LA23_0<=49)||LA23_0==51||(LA23_0>=54 && LA23_0<=55)||(LA23_0>=58 && LA23_0<=59)||(LA23_0>=91 && LA23_0<=92)||(LA23_0>=96 && LA23_0<=106)))
			{
				alt23=1;
			}
			} finally { DebugExitDecision(23); }
			switch (alt23)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: statementList
				{
				DebugLocation(67, 13);
				PushFollow(Follow._statementList_in_statementBlock320);
				statementList54=statementList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementList54.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(23); }

			DebugLocation(67, 30);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:67:30: ( LT )*
			try { DebugEnterSubRule(24);
			while (true)
			{
				int alt24=2;
				try { DebugEnterDecision(24, decisionCanBacktrack[24]);
				int LA24_0 = input.LA(1);

				if ((LA24_0==LT))
				{
					alt24=1;
				}


				} finally { DebugExitDecision(24); }
				switch ( alt24 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(67, 30);
					LT55=(IToken)Match(input,LT,Follow._LT_in_statementBlock323); if (state.failed) return retval;

					}
					break;

				default:
					goto loop24;
				}
			}

			loop24:
				;

			} finally { DebugExitSubRule(24); }

			DebugLocation(67, 33);
			char_literal56=(IToken)Match(input,36,Follow._36_in_statementBlock327); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal56_tree = (object)adaptor.Create(char_literal56);
			adaptor.AddChild(root_0, char_literal56_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("statementBlock", 9);
			LeaveRule("statementBlock", 9);
			Leave_statementBlock();
			if (state.backtracking > 0) { Memoize(input, 9, statementBlock_StartIndex); }
		}
		DebugLocation(68, 1);
		} finally { DebugExitRule(GrammarFileName, "statementBlock"); }
		return retval;

	}
	// $ANTLR end "statementBlock"

	public class statementList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_statementList();
	partial void Leave_statementList();

	// $ANTLR start "statementList"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:70:1: statementList : statement ( ( LT )* statement )* ;
	[GrammarRule("statementList")]
	private JavaScriptParser.statementList_return statementList()
	{
		Enter_statementList();
		EnterRule("statementList", 10);
		TraceIn("statementList", 10);
		JavaScriptParser.statementList_return retval = new JavaScriptParser.statementList_return();
		retval.Start = (IToken)input.LT(1);
		int statementList_StartIndex = input.Index;
		object root_0 = null;

		IToken LT58=null;
		JavaScriptParser.statement_return statement57 = default(JavaScriptParser.statement_return);
		JavaScriptParser.statement_return statement59 = default(JavaScriptParser.statement_return);

		object LT58_tree=null;

		try { DebugEnterRule(GrammarFileName, "statementList");
		DebugLocation(70, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:71:2: ( statement ( ( LT )* statement )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:71:4: statement ( ( LT )* statement )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(71, 4);
			PushFollow(Follow._statement_in_statementList339);
			statement57=statement();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement57.Tree);
			DebugLocation(71, 14);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:71:14: ( ( LT )* statement )*
			try { DebugEnterSubRule(26);
			while (true)
			{
				int alt26=2;
				try { DebugEnterDecision(26, decisionCanBacktrack[26]);
				try
				{
					alt26 = dfa26.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(26); }
				switch ( alt26 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:71:15: ( LT )* statement
					{
					DebugLocation(71, 17);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:71:17: ( LT )*
					try { DebugEnterSubRule(25);
					while (true)
					{
						int alt25=2;
						try { DebugEnterDecision(25, decisionCanBacktrack[25]);
						int LA25_0 = input.LA(1);

						if ((LA25_0==LT))
						{
							alt25=1;
						}


						} finally { DebugExitDecision(25); }
						switch ( alt25 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(71, 17);
							LT58=(IToken)Match(input,LT,Follow._LT_in_statementList342); if (state.failed) return retval;

							}
							break;

						default:
							goto loop25;
						}
					}

					loop25:
						;

					} finally { DebugExitSubRule(25); }

					DebugLocation(71, 20);
					PushFollow(Follow._statement_in_statementList346);
					statement59=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement59.Tree);

					}
					break;

				default:
					goto loop26;
				}
			}

			loop26:
				;

			} finally { DebugExitSubRule(26); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("statementList", 10);
			LeaveRule("statementList", 10);
			Leave_statementList();
			if (state.backtracking > 0) { Memoize(input, 10, statementList_StartIndex); }
		}
		DebugLocation(72, 1);
		} finally { DebugExitRule(GrammarFileName, "statementList"); }
		return retval;

	}
	// $ANTLR end "statementList"

	public class variableStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_variableStatement();
	partial void Leave_variableStatement();

	// $ANTLR start "variableStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:74:1: variableStatement : 'var' ( LT )* variableDeclarationList ( LT | ';' ) ;
	[GrammarRule("variableStatement")]
	private JavaScriptParser.variableStatement_return variableStatement()
	{
		Enter_variableStatement();
		EnterRule("variableStatement", 11);
		TraceIn("variableStatement", 11);
		JavaScriptParser.variableStatement_return retval = new JavaScriptParser.variableStatement_return();
		retval.Start = (IToken)input.LT(1);
		int variableStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal60=null;
		IToken LT61=null;
		IToken set63=null;
		JavaScriptParser.variableDeclarationList_return variableDeclarationList62 = default(JavaScriptParser.variableDeclarationList_return);

		object string_literal60_tree=null;
		object LT61_tree=null;
		object set63_tree=null;

		try { DebugEnterRule(GrammarFileName, "variableStatement");
		DebugLocation(74, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:75:2: ( 'var' ( LT )* variableDeclarationList ( LT | ';' ) )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:75:4: 'var' ( LT )* variableDeclarationList ( LT | ';' )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(75, 4);
			string_literal60=(IToken)Match(input,37,Follow._37_in_variableStatement360); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal60_tree = (object)adaptor.Create(string_literal60);
			adaptor.AddChild(root_0, string_literal60_tree);
			}
			DebugLocation(75, 12);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:75:12: ( LT )*
			try { DebugEnterSubRule(27);
			while (true)
			{
				int alt27=2;
				try { DebugEnterDecision(27, decisionCanBacktrack[27]);
				int LA27_0 = input.LA(1);

				if ((LA27_0==LT))
				{
					alt27=1;
				}


				} finally { DebugExitDecision(27); }
				switch ( alt27 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(75, 12);
					LT61=(IToken)Match(input,LT,Follow._LT_in_variableStatement362); if (state.failed) return retval;

					}
					break;

				default:
					goto loop27;
				}
			}

			loop27:
				;

			} finally { DebugExitSubRule(27); }

			DebugLocation(75, 15);
			PushFollow(Follow._variableDeclarationList_in_variableStatement366);
			variableDeclarationList62=variableDeclarationList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclarationList62.Tree);
			DebugLocation(75, 39);
			set63=(IToken)input.LT(1);
			if (input.LA(1)==LT||input.LA(1)==38)
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("variableStatement", 11);
			LeaveRule("variableStatement", 11);
			Leave_variableStatement();
			if (state.backtracking > 0) { Memoize(input, 11, variableStatement_StartIndex); }
		}
		DebugLocation(76, 1);
		} finally { DebugExitRule(GrammarFileName, "variableStatement"); }
		return retval;

	}
	// $ANTLR end "variableStatement"

	public class variableDeclarationList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_variableDeclarationList();
	partial void Leave_variableDeclarationList();

	// $ANTLR start "variableDeclarationList"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:78:1: variableDeclarationList : variableDeclaration ( ( LT )* ',' ( LT )* variableDeclaration )* ;
	[GrammarRule("variableDeclarationList")]
	private JavaScriptParser.variableDeclarationList_return variableDeclarationList()
	{
		Enter_variableDeclarationList();
		EnterRule("variableDeclarationList", 12);
		TraceIn("variableDeclarationList", 12);
		JavaScriptParser.variableDeclarationList_return retval = new JavaScriptParser.variableDeclarationList_return();
		retval.Start = (IToken)input.LT(1);
		int variableDeclarationList_StartIndex = input.Index;
		object root_0 = null;

		IToken LT65=null;
		IToken char_literal66=null;
		IToken LT67=null;
		JavaScriptParser.variableDeclaration_return variableDeclaration64 = default(JavaScriptParser.variableDeclaration_return);
		JavaScriptParser.variableDeclaration_return variableDeclaration68 = default(JavaScriptParser.variableDeclaration_return);

		object LT65_tree=null;
		object char_literal66_tree=null;
		object LT67_tree=null;

		try { DebugEnterRule(GrammarFileName, "variableDeclarationList");
		DebugLocation(78, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:79:2: ( variableDeclaration ( ( LT )* ',' ( LT )* variableDeclaration )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:79:4: variableDeclaration ( ( LT )* ',' ( LT )* variableDeclaration )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(79, 4);
			PushFollow(Follow._variableDeclaration_in_variableDeclarationList387);
			variableDeclaration64=variableDeclaration();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclaration64.Tree);
			DebugLocation(79, 24);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:79:24: ( ( LT )* ',' ( LT )* variableDeclaration )*
			try { DebugEnterSubRule(30);
			while (true)
			{
				int alt30=2;
				try { DebugEnterDecision(30, decisionCanBacktrack[30]);
				try
				{
					alt30 = dfa30.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(30); }
				switch ( alt30 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:79:25: ( LT )* ',' ( LT )* variableDeclaration
					{
					DebugLocation(79, 27);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:79:27: ( LT )*
					try { DebugEnterSubRule(28);
					while (true)
					{
						int alt28=2;
						try { DebugEnterDecision(28, decisionCanBacktrack[28]);
						int LA28_0 = input.LA(1);

						if ((LA28_0==LT))
						{
							alt28=1;
						}


						} finally { DebugExitDecision(28); }
						switch ( alt28 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(79, 27);
							LT65=(IToken)Match(input,LT,Follow._LT_in_variableDeclarationList390); if (state.failed) return retval;

							}
							break;

						default:
							goto loop28;
						}
					}

					loop28:
						;

					} finally { DebugExitSubRule(28); }

					DebugLocation(79, 30);
					char_literal66=(IToken)Match(input,33,Follow._33_in_variableDeclarationList394); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					char_literal66_tree = (object)adaptor.Create(char_literal66);
					adaptor.AddChild(root_0, char_literal66_tree);
					}
					DebugLocation(79, 36);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:79:36: ( LT )*
					try { DebugEnterSubRule(29);
					while (true)
					{
						int alt29=2;
						try { DebugEnterDecision(29, decisionCanBacktrack[29]);
						int LA29_0 = input.LA(1);

						if ((LA29_0==LT))
						{
							alt29=1;
						}


						} finally { DebugExitDecision(29); }
						switch ( alt29 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(79, 36);
							LT67=(IToken)Match(input,LT,Follow._LT_in_variableDeclarationList396); if (state.failed) return retval;

							}
							break;

						default:
							goto loop29;
						}
					}

					loop29:
						;

					} finally { DebugExitSubRule(29); }

					DebugLocation(79, 39);
					PushFollow(Follow._variableDeclaration_in_variableDeclarationList400);
					variableDeclaration68=variableDeclaration();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclaration68.Tree);

					}
					break;

				default:
					goto loop30;
				}
			}

			loop30:
				;

			} finally { DebugExitSubRule(30); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("variableDeclarationList", 12);
			LeaveRule("variableDeclarationList", 12);
			Leave_variableDeclarationList();
			if (state.backtracking > 0) { Memoize(input, 12, variableDeclarationList_StartIndex); }
		}
		DebugLocation(80, 1);
		} finally { DebugExitRule(GrammarFileName, "variableDeclarationList"); }
		return retval;

	}
	// $ANTLR end "variableDeclarationList"

	public class variableDeclarationListNoIn_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_variableDeclarationListNoIn();
	partial void Leave_variableDeclarationListNoIn();

	// $ANTLR start "variableDeclarationListNoIn"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:82:1: variableDeclarationListNoIn : variableDeclarationNoIn ( ( LT )* ',' ( LT )* variableDeclarationNoIn )* ;
	[GrammarRule("variableDeclarationListNoIn")]
	private JavaScriptParser.variableDeclarationListNoIn_return variableDeclarationListNoIn()
	{
		Enter_variableDeclarationListNoIn();
		EnterRule("variableDeclarationListNoIn", 13);
		TraceIn("variableDeclarationListNoIn", 13);
		JavaScriptParser.variableDeclarationListNoIn_return retval = new JavaScriptParser.variableDeclarationListNoIn_return();
		retval.Start = (IToken)input.LT(1);
		int variableDeclarationListNoIn_StartIndex = input.Index;
		object root_0 = null;

		IToken LT70=null;
		IToken char_literal71=null;
		IToken LT72=null;
		JavaScriptParser.variableDeclarationNoIn_return variableDeclarationNoIn69 = default(JavaScriptParser.variableDeclarationNoIn_return);
		JavaScriptParser.variableDeclarationNoIn_return variableDeclarationNoIn73 = default(JavaScriptParser.variableDeclarationNoIn_return);

		object LT70_tree=null;
		object char_literal71_tree=null;
		object LT72_tree=null;

		try { DebugEnterRule(GrammarFileName, "variableDeclarationListNoIn");
		DebugLocation(82, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:83:2: ( variableDeclarationNoIn ( ( LT )* ',' ( LT )* variableDeclarationNoIn )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:83:4: variableDeclarationNoIn ( ( LT )* ',' ( LT )* variableDeclarationNoIn )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(83, 4);
			PushFollow(Follow._variableDeclarationNoIn_in_variableDeclarationListNoIn414);
			variableDeclarationNoIn69=variableDeclarationNoIn();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclarationNoIn69.Tree);
			DebugLocation(83, 28);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:83:28: ( ( LT )* ',' ( LT )* variableDeclarationNoIn )*
			try { DebugEnterSubRule(33);
			while (true)
			{
				int alt33=2;
				try { DebugEnterDecision(33, decisionCanBacktrack[33]);
				try
				{
					alt33 = dfa33.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(33); }
				switch ( alt33 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:83:29: ( LT )* ',' ( LT )* variableDeclarationNoIn
					{
					DebugLocation(83, 31);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:83:31: ( LT )*
					try { DebugEnterSubRule(31);
					while (true)
					{
						int alt31=2;
						try { DebugEnterDecision(31, decisionCanBacktrack[31]);
						int LA31_0 = input.LA(1);

						if ((LA31_0==LT))
						{
							alt31=1;
						}


						} finally { DebugExitDecision(31); }
						switch ( alt31 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(83, 31);
							LT70=(IToken)Match(input,LT,Follow._LT_in_variableDeclarationListNoIn417); if (state.failed) return retval;

							}
							break;

						default:
							goto loop31;
						}
					}

					loop31:
						;

					} finally { DebugExitSubRule(31); }

					DebugLocation(83, 34);
					char_literal71=(IToken)Match(input,33,Follow._33_in_variableDeclarationListNoIn421); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					char_literal71_tree = (object)adaptor.Create(char_literal71);
					adaptor.AddChild(root_0, char_literal71_tree);
					}
					DebugLocation(83, 40);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:83:40: ( LT )*
					try { DebugEnterSubRule(32);
					while (true)
					{
						int alt32=2;
						try { DebugEnterDecision(32, decisionCanBacktrack[32]);
						int LA32_0 = input.LA(1);

						if ((LA32_0==LT))
						{
							alt32=1;
						}


						} finally { DebugExitDecision(32); }
						switch ( alt32 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(83, 40);
							LT72=(IToken)Match(input,LT,Follow._LT_in_variableDeclarationListNoIn423); if (state.failed) return retval;

							}
							break;

						default:
							goto loop32;
						}
					}

					loop32:
						;

					} finally { DebugExitSubRule(32); }

					DebugLocation(83, 43);
					PushFollow(Follow._variableDeclarationNoIn_in_variableDeclarationListNoIn427);
					variableDeclarationNoIn73=variableDeclarationNoIn();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclarationNoIn73.Tree);

					}
					break;

				default:
					goto loop33;
				}
			}

			loop33:
				;

			} finally { DebugExitSubRule(33); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("variableDeclarationListNoIn", 13);
			LeaveRule("variableDeclarationListNoIn", 13);
			Leave_variableDeclarationListNoIn();
			if (state.backtracking > 0) { Memoize(input, 13, variableDeclarationListNoIn_StartIndex); }
		}
		DebugLocation(84, 1);
		} finally { DebugExitRule(GrammarFileName, "variableDeclarationListNoIn"); }
		return retval;

	}
	// $ANTLR end "variableDeclarationListNoIn"

	public class variableDeclaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_variableDeclaration();
	partial void Leave_variableDeclaration();

	// $ANTLR start "variableDeclaration"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:86:1: variableDeclaration : Identifier ( LT )* ( initialiser )? ;
	[GrammarRule("variableDeclaration")]
	private JavaScriptParser.variableDeclaration_return variableDeclaration()
	{
		Enter_variableDeclaration();
		EnterRule("variableDeclaration", 14);
		TraceIn("variableDeclaration", 14);
		JavaScriptParser.variableDeclaration_return retval = new JavaScriptParser.variableDeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int variableDeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken Identifier74=null;
		IToken LT75=null;
		JavaScriptParser.initialiser_return initialiser76 = default(JavaScriptParser.initialiser_return);

		object Identifier74_tree=null;
		object LT75_tree=null;

		try { DebugEnterRule(GrammarFileName, "variableDeclaration");
		DebugLocation(86, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:87:2: ( Identifier ( LT )* ( initialiser )? )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:87:4: Identifier ( LT )* ( initialiser )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(87, 4);
			Identifier74=(IToken)Match(input,Identifier,Follow._Identifier_in_variableDeclaration441); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			Identifier74_tree = (object)adaptor.Create(Identifier74);
			adaptor.AddChild(root_0, Identifier74_tree);
			}
			DebugLocation(87, 17);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:87:17: ( LT )*
			try { DebugEnterSubRule(34);
			while (true)
			{
				int alt34=2;
				try { DebugEnterDecision(34, decisionCanBacktrack[34]);
				int LA34_0 = input.LA(1);

				if ((LA34_0==LT))
				{
					int LA34_2 = input.LA(2);

					if ((EvaluatePredicate(synpred47_JavaScript_fragment)))
					{
						alt34=1;
					}


				}


				} finally { DebugExitDecision(34); }
				switch ( alt34 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(87, 17);
					LT75=(IToken)Match(input,LT,Follow._LT_in_variableDeclaration443); if (state.failed) return retval;

					}
					break;

				default:
					goto loop34;
				}
			}

			loop34:
				;

			} finally { DebugExitSubRule(34); }

			DebugLocation(87, 20);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:87:20: ( initialiser )?
			int alt35=2;
			try { DebugEnterSubRule(35);
			try { DebugEnterDecision(35, decisionCanBacktrack[35]);
			int LA35_0 = input.LA(1);

			if ((LA35_0==39))
			{
				alt35=1;
			}
			} finally { DebugExitDecision(35); }
			switch (alt35)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: initialiser
				{
				DebugLocation(87, 20);
				PushFollow(Follow._initialiser_in_variableDeclaration447);
				initialiser76=initialiser();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, initialiser76.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(35); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("variableDeclaration", 14);
			LeaveRule("variableDeclaration", 14);
			Leave_variableDeclaration();
			if (state.backtracking > 0) { Memoize(input, 14, variableDeclaration_StartIndex); }
		}
		DebugLocation(88, 1);
		} finally { DebugExitRule(GrammarFileName, "variableDeclaration"); }
		return retval;

	}
	// $ANTLR end "variableDeclaration"

	public class variableDeclarationNoIn_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_variableDeclarationNoIn();
	partial void Leave_variableDeclarationNoIn();

	// $ANTLR start "variableDeclarationNoIn"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:90:1: variableDeclarationNoIn : Identifier ( LT )* ( initialiserNoIn )? ;
	[GrammarRule("variableDeclarationNoIn")]
	private JavaScriptParser.variableDeclarationNoIn_return variableDeclarationNoIn()
	{
		Enter_variableDeclarationNoIn();
		EnterRule("variableDeclarationNoIn", 15);
		TraceIn("variableDeclarationNoIn", 15);
		JavaScriptParser.variableDeclarationNoIn_return retval = new JavaScriptParser.variableDeclarationNoIn_return();
		retval.Start = (IToken)input.LT(1);
		int variableDeclarationNoIn_StartIndex = input.Index;
		object root_0 = null;

		IToken Identifier77=null;
		IToken LT78=null;
		JavaScriptParser.initialiserNoIn_return initialiserNoIn79 = default(JavaScriptParser.initialiserNoIn_return);

		object Identifier77_tree=null;
		object LT78_tree=null;

		try { DebugEnterRule(GrammarFileName, "variableDeclarationNoIn");
		DebugLocation(90, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:91:2: ( Identifier ( LT )* ( initialiserNoIn )? )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:91:4: Identifier ( LT )* ( initialiserNoIn )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(91, 4);
			Identifier77=(IToken)Match(input,Identifier,Follow._Identifier_in_variableDeclarationNoIn460); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			Identifier77_tree = (object)adaptor.Create(Identifier77);
			adaptor.AddChild(root_0, Identifier77_tree);
			}
			DebugLocation(91, 17);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:91:17: ( LT )*
			try { DebugEnterSubRule(36);
			while (true)
			{
				int alt36=2;
				try { DebugEnterDecision(36, decisionCanBacktrack[36]);
				int LA36_0 = input.LA(1);

				if ((LA36_0==LT))
				{
					int LA36_2 = input.LA(2);

					if ((EvaluatePredicate(synpred49_JavaScript_fragment)))
					{
						alt36=1;
					}


				}


				} finally { DebugExitDecision(36); }
				switch ( alt36 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(91, 17);
					LT78=(IToken)Match(input,LT,Follow._LT_in_variableDeclarationNoIn462); if (state.failed) return retval;

					}
					break;

				default:
					goto loop36;
				}
			}

			loop36:
				;

			} finally { DebugExitSubRule(36); }

			DebugLocation(91, 20);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:91:20: ( initialiserNoIn )?
			int alt37=2;
			try { DebugEnterSubRule(37);
			try { DebugEnterDecision(37, decisionCanBacktrack[37]);
			int LA37_0 = input.LA(1);

			if ((LA37_0==39))
			{
				alt37=1;
			}
			} finally { DebugExitDecision(37); }
			switch (alt37)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: initialiserNoIn
				{
				DebugLocation(91, 20);
				PushFollow(Follow._initialiserNoIn_in_variableDeclarationNoIn466);
				initialiserNoIn79=initialiserNoIn();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, initialiserNoIn79.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(37); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("variableDeclarationNoIn", 15);
			LeaveRule("variableDeclarationNoIn", 15);
			Leave_variableDeclarationNoIn();
			if (state.backtracking > 0) { Memoize(input, 15, variableDeclarationNoIn_StartIndex); }
		}
		DebugLocation(92, 1);
		} finally { DebugExitRule(GrammarFileName, "variableDeclarationNoIn"); }
		return retval;

	}
	// $ANTLR end "variableDeclarationNoIn"

	public class initialiser_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_initialiser();
	partial void Leave_initialiser();

	// $ANTLR start "initialiser"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:94:1: initialiser : '=' ( LT )* assignmentExpression ;
	[GrammarRule("initialiser")]
	private JavaScriptParser.initialiser_return initialiser()
	{
		Enter_initialiser();
		EnterRule("initialiser", 16);
		TraceIn("initialiser", 16);
		JavaScriptParser.initialiser_return retval = new JavaScriptParser.initialiser_return();
		retval.Start = (IToken)input.LT(1);
		int initialiser_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal80=null;
		IToken LT81=null;
		JavaScriptParser.assignmentExpression_return assignmentExpression82 = default(JavaScriptParser.assignmentExpression_return);

		object char_literal80_tree=null;
		object LT81_tree=null;

		try { DebugEnterRule(GrammarFileName, "initialiser");
		DebugLocation(94, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:95:2: ( '=' ( LT )* assignmentExpression )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:95:4: '=' ( LT )* assignmentExpression
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(95, 4);
			char_literal80=(IToken)Match(input,39,Follow._39_in_initialiser479); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal80_tree = (object)adaptor.Create(char_literal80);
			adaptor.AddChild(root_0, char_literal80_tree);
			}
			DebugLocation(95, 10);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:95:10: ( LT )*
			try { DebugEnterSubRule(38);
			while (true)
			{
				int alt38=2;
				try { DebugEnterDecision(38, decisionCanBacktrack[38]);
				int LA38_0 = input.LA(1);

				if ((LA38_0==LT))
				{
					alt38=1;
				}


				} finally { DebugExitDecision(38); }
				switch ( alt38 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(95, 10);
					LT81=(IToken)Match(input,LT,Follow._LT_in_initialiser481); if (state.failed) return retval;

					}
					break;

				default:
					goto loop38;
				}
			}

			loop38:
				;

			} finally { DebugExitSubRule(38); }

			DebugLocation(95, 13);
			PushFollow(Follow._assignmentExpression_in_initialiser485);
			assignmentExpression82=assignmentExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression82.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("initialiser", 16);
			LeaveRule("initialiser", 16);
			Leave_initialiser();
			if (state.backtracking > 0) { Memoize(input, 16, initialiser_StartIndex); }
		}
		DebugLocation(96, 1);
		} finally { DebugExitRule(GrammarFileName, "initialiser"); }
		return retval;

	}
	// $ANTLR end "initialiser"

	public class initialiserNoIn_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_initialiserNoIn();
	partial void Leave_initialiserNoIn();

	// $ANTLR start "initialiserNoIn"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:98:1: initialiserNoIn : '=' ( LT )* assignmentExpressionNoIn ;
	[GrammarRule("initialiserNoIn")]
	private JavaScriptParser.initialiserNoIn_return initialiserNoIn()
	{
		Enter_initialiserNoIn();
		EnterRule("initialiserNoIn", 17);
		TraceIn("initialiserNoIn", 17);
		JavaScriptParser.initialiserNoIn_return retval = new JavaScriptParser.initialiserNoIn_return();
		retval.Start = (IToken)input.LT(1);
		int initialiserNoIn_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal83=null;
		IToken LT84=null;
		JavaScriptParser.assignmentExpressionNoIn_return assignmentExpressionNoIn85 = default(JavaScriptParser.assignmentExpressionNoIn_return);

		object char_literal83_tree=null;
		object LT84_tree=null;

		try { DebugEnterRule(GrammarFileName, "initialiserNoIn");
		DebugLocation(98, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:99:2: ( '=' ( LT )* assignmentExpressionNoIn )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:99:4: '=' ( LT )* assignmentExpressionNoIn
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(99, 4);
			char_literal83=(IToken)Match(input,39,Follow._39_in_initialiserNoIn497); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal83_tree = (object)adaptor.Create(char_literal83);
			adaptor.AddChild(root_0, char_literal83_tree);
			}
			DebugLocation(99, 10);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:99:10: ( LT )*
			try { DebugEnterSubRule(39);
			while (true)
			{
				int alt39=2;
				try { DebugEnterDecision(39, decisionCanBacktrack[39]);
				int LA39_0 = input.LA(1);

				if ((LA39_0==LT))
				{
					alt39=1;
				}


				} finally { DebugExitDecision(39); }
				switch ( alt39 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(99, 10);
					LT84=(IToken)Match(input,LT,Follow._LT_in_initialiserNoIn499); if (state.failed) return retval;

					}
					break;

				default:
					goto loop39;
				}
			}

			loop39:
				;

			} finally { DebugExitSubRule(39); }

			DebugLocation(99, 13);
			PushFollow(Follow._assignmentExpressionNoIn_in_initialiserNoIn503);
			assignmentExpressionNoIn85=assignmentExpressionNoIn();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpressionNoIn85.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("initialiserNoIn", 17);
			LeaveRule("initialiserNoIn", 17);
			Leave_initialiserNoIn();
			if (state.backtracking > 0) { Memoize(input, 17, initialiserNoIn_StartIndex); }
		}
		DebugLocation(100, 1);
		} finally { DebugExitRule(GrammarFileName, "initialiserNoIn"); }
		return retval;

	}
	// $ANTLR end "initialiserNoIn"

	public class emptyStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_emptyStatement();
	partial void Leave_emptyStatement();

	// $ANTLR start "emptyStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:102:1: emptyStatement : ';' ;
	[GrammarRule("emptyStatement")]
	private JavaScriptParser.emptyStatement_return emptyStatement()
	{
		Enter_emptyStatement();
		EnterRule("emptyStatement", 18);
		TraceIn("emptyStatement", 18);
		JavaScriptParser.emptyStatement_return retval = new JavaScriptParser.emptyStatement_return();
		retval.Start = (IToken)input.LT(1);
		int emptyStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal86=null;

		object char_literal86_tree=null;

		try { DebugEnterRule(GrammarFileName, "emptyStatement");
		DebugLocation(102, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:103:2: ( ';' )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:103:4: ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(103, 4);
			char_literal86=(IToken)Match(input,38,Follow._38_in_emptyStatement515); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal86_tree = (object)adaptor.Create(char_literal86);
			adaptor.AddChild(root_0, char_literal86_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("emptyStatement", 18);
			LeaveRule("emptyStatement", 18);
			Leave_emptyStatement();
			if (state.backtracking > 0) { Memoize(input, 18, emptyStatement_StartIndex); }
		}
		DebugLocation(104, 1);
		} finally { DebugExitRule(GrammarFileName, "emptyStatement"); }
		return retval;

	}
	// $ANTLR end "emptyStatement"

	public class expressionStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expressionStatement();
	partial void Leave_expressionStatement();

	// $ANTLR start "expressionStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:106:1: expressionStatement : expression ( LT | ';' ) ;
	[GrammarRule("expressionStatement")]
	private JavaScriptParser.expressionStatement_return expressionStatement()
	{
		Enter_expressionStatement();
		EnterRule("expressionStatement", 19);
		TraceIn("expressionStatement", 19);
		JavaScriptParser.expressionStatement_return retval = new JavaScriptParser.expressionStatement_return();
		retval.Start = (IToken)input.LT(1);
		int expressionStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken set88=null;
		JavaScriptParser.expression_return expression87 = default(JavaScriptParser.expression_return);

		object set88_tree=null;

		try { DebugEnterRule(GrammarFileName, "expressionStatement");
		DebugLocation(106, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:107:2: ( expression ( LT | ';' ) )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:107:4: expression ( LT | ';' )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(107, 4);
			PushFollow(Follow._expression_in_expressionStatement527);
			expression87=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression87.Tree);
			DebugLocation(107, 15);
			set88=(IToken)input.LT(1);
			if (input.LA(1)==LT||input.LA(1)==38)
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expressionStatement", 19);
			LeaveRule("expressionStatement", 19);
			Leave_expressionStatement();
			if (state.backtracking > 0) { Memoize(input, 19, expressionStatement_StartIndex); }
		}
		DebugLocation(108, 1);
		} finally { DebugExitRule(GrammarFileName, "expressionStatement"); }
		return retval;

	}
	// $ANTLR end "expressionStatement"

	public class ifStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_ifStatement();
	partial void Leave_ifStatement();

	// $ANTLR start "ifStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:110:1: ifStatement : 'if' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement ( ( LT )* 'else' ( LT )* statement )? ;
	[GrammarRule("ifStatement")]
	private JavaScriptParser.ifStatement_return ifStatement()
	{
		Enter_ifStatement();
		EnterRule("ifStatement", 20);
		TraceIn("ifStatement", 20);
		JavaScriptParser.ifStatement_return retval = new JavaScriptParser.ifStatement_return();
		retval.Start = (IToken)input.LT(1);
		int ifStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal89=null;
		IToken LT90=null;
		IToken char_literal91=null;
		IToken LT92=null;
		IToken LT94=null;
		IToken char_literal95=null;
		IToken LT96=null;
		IToken LT98=null;
		IToken string_literal99=null;
		IToken LT100=null;
		JavaScriptParser.expression_return expression93 = default(JavaScriptParser.expression_return);
		JavaScriptParser.statement_return statement97 = default(JavaScriptParser.statement_return);
		JavaScriptParser.statement_return statement101 = default(JavaScriptParser.statement_return);

		object string_literal89_tree=null;
		object LT90_tree=null;
		object char_literal91_tree=null;
		object LT92_tree=null;
		object LT94_tree=null;
		object char_literal95_tree=null;
		object LT96_tree=null;
		object LT98_tree=null;
		object string_literal99_tree=null;
		object LT100_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifStatement");
		DebugLocation(110, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:111:2: ( 'if' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement ( ( LT )* 'else' ( LT )* statement )? )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:111:4: 'if' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement ( ( LT )* 'else' ( LT )* statement )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(111, 4);
			string_literal89=(IToken)Match(input,40,Follow._40_in_ifStatement548); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal89_tree = (object)adaptor.Create(string_literal89);
			adaptor.AddChild(root_0, string_literal89_tree);
			}
			DebugLocation(111, 11);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:111:11: ( LT )*
			try { DebugEnterSubRule(40);
			while (true)
			{
				int alt40=2;
				try { DebugEnterDecision(40, decisionCanBacktrack[40]);
				int LA40_0 = input.LA(1);

				if ((LA40_0==LT))
				{
					alt40=1;
				}


				} finally { DebugExitDecision(40); }
				switch ( alt40 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(111, 11);
					LT90=(IToken)Match(input,LT,Follow._LT_in_ifStatement550); if (state.failed) return retval;

					}
					break;

				default:
					goto loop40;
				}
			}

			loop40:
				;

			} finally { DebugExitSubRule(40); }

			DebugLocation(111, 14);
			char_literal91=(IToken)Match(input,32,Follow._32_in_ifStatement554); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal91_tree = (object)adaptor.Create(char_literal91);
			adaptor.AddChild(root_0, char_literal91_tree);
			}
			DebugLocation(111, 20);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:111:20: ( LT )*
			try { DebugEnterSubRule(41);
			while (true)
			{
				int alt41=2;
				try { DebugEnterDecision(41, decisionCanBacktrack[41]);
				int LA41_0 = input.LA(1);

				if ((LA41_0==LT))
				{
					alt41=1;
				}


				} finally { DebugExitDecision(41); }
				switch ( alt41 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(111, 20);
					LT92=(IToken)Match(input,LT,Follow._LT_in_ifStatement556); if (state.failed) return retval;

					}
					break;

				default:
					goto loop41;
				}
			}

			loop41:
				;

			} finally { DebugExitSubRule(41); }

			DebugLocation(111, 23);
			PushFollow(Follow._expression_in_ifStatement560);
			expression93=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression93.Tree);
			DebugLocation(111, 36);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:111:36: ( LT )*
			try { DebugEnterSubRule(42);
			while (true)
			{
				int alt42=2;
				try { DebugEnterDecision(42, decisionCanBacktrack[42]);
				int LA42_0 = input.LA(1);

				if ((LA42_0==LT))
				{
					alt42=1;
				}


				} finally { DebugExitDecision(42); }
				switch ( alt42 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(111, 36);
					LT94=(IToken)Match(input,LT,Follow._LT_in_ifStatement562); if (state.failed) return retval;

					}
					break;

				default:
					goto loop42;
				}
			}

			loop42:
				;

			} finally { DebugExitSubRule(42); }

			DebugLocation(111, 39);
			char_literal95=(IToken)Match(input,34,Follow._34_in_ifStatement566); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal95_tree = (object)adaptor.Create(char_literal95);
			adaptor.AddChild(root_0, char_literal95_tree);
			}
			DebugLocation(111, 45);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:111:45: ( LT )*
			try { DebugEnterSubRule(43);
			while (true)
			{
				int alt43=2;
				try { DebugEnterDecision(43, decisionCanBacktrack[43]);
				int LA43_0 = input.LA(1);

				if ((LA43_0==LT))
				{
					alt43=1;
				}


				} finally { DebugExitDecision(43); }
				switch ( alt43 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(111, 45);
					LT96=(IToken)Match(input,LT,Follow._LT_in_ifStatement568); if (state.failed) return retval;

					}
					break;

				default:
					goto loop43;
				}
			}

			loop43:
				;

			} finally { DebugExitSubRule(43); }

			DebugLocation(111, 48);
			PushFollow(Follow._statement_in_ifStatement572);
			statement97=statement();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement97.Tree);
			DebugLocation(111, 58);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:111:58: ( ( LT )* 'else' ( LT )* statement )?
			int alt46=2;
			try { DebugEnterSubRule(46);
			try { DebugEnterDecision(46, decisionCanBacktrack[46]);
			int LA46_0 = input.LA(1);

			if ((LA46_0==LT))
			{
				int LA46_1 = input.LA(2);

				if ((EvaluatePredicate(synpred60_JavaScript_fragment)))
				{
					alt46=1;
				}
			}
			else if ((LA46_0==41))
			{
				int LA46_2 = input.LA(2);

				if ((EvaluatePredicate(synpred60_JavaScript_fragment)))
				{
					alt46=1;
				}
			}
			} finally { DebugExitDecision(46); }
			switch (alt46)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:111:59: ( LT )* 'else' ( LT )* statement
				{
				DebugLocation(111, 61);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:111:61: ( LT )*
				try { DebugEnterSubRule(44);
				while (true)
				{
					int alt44=2;
					try { DebugEnterDecision(44, decisionCanBacktrack[44]);
					int LA44_0 = input.LA(1);

					if ((LA44_0==LT))
					{
						alt44=1;
					}


					} finally { DebugExitDecision(44); }
					switch ( alt44 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(111, 61);
						LT98=(IToken)Match(input,LT,Follow._LT_in_ifStatement575); if (state.failed) return retval;

						}
						break;

					default:
						goto loop44;
					}
				}

				loop44:
					;

				} finally { DebugExitSubRule(44); }

				DebugLocation(111, 64);
				string_literal99=(IToken)Match(input,41,Follow._41_in_ifStatement579); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				string_literal99_tree = (object)adaptor.Create(string_literal99);
				adaptor.AddChild(root_0, string_literal99_tree);
				}
				DebugLocation(111, 73);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:111:73: ( LT )*
				try { DebugEnterSubRule(45);
				while (true)
				{
					int alt45=2;
					try { DebugEnterDecision(45, decisionCanBacktrack[45]);
					int LA45_0 = input.LA(1);

					if ((LA45_0==LT))
					{
						alt45=1;
					}


					} finally { DebugExitDecision(45); }
					switch ( alt45 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(111, 73);
						LT100=(IToken)Match(input,LT,Follow._LT_in_ifStatement581); if (state.failed) return retval;

						}
						break;

					default:
						goto loop45;
					}
				}

				loop45:
					;

				} finally { DebugExitSubRule(45); }

				DebugLocation(111, 76);
				PushFollow(Follow._statement_in_ifStatement585);
				statement101=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement101.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(46); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("ifStatement", 20);
			LeaveRule("ifStatement", 20);
			Leave_ifStatement();
			if (state.backtracking > 0) { Memoize(input, 20, ifStatement_StartIndex); }
		}
		DebugLocation(112, 1);
		} finally { DebugExitRule(GrammarFileName, "ifStatement"); }
		return retval;

	}
	// $ANTLR end "ifStatement"

	public class iterationStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_iterationStatement();
	partial void Leave_iterationStatement();

	// $ANTLR start "iterationStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:114:1: iterationStatement : ( doWhileStatement | whileStatement | forStatement | forInStatement );
	[GrammarRule("iterationStatement")]
	private JavaScriptParser.iterationStatement_return iterationStatement()
	{
		Enter_iterationStatement();
		EnterRule("iterationStatement", 21);
		TraceIn("iterationStatement", 21);
		JavaScriptParser.iterationStatement_return retval = new JavaScriptParser.iterationStatement_return();
		retval.Start = (IToken)input.LT(1);
		int iterationStatement_StartIndex = input.Index;
		object root_0 = null;

		JavaScriptParser.doWhileStatement_return doWhileStatement102 = default(JavaScriptParser.doWhileStatement_return);
		JavaScriptParser.whileStatement_return whileStatement103 = default(JavaScriptParser.whileStatement_return);
		JavaScriptParser.forStatement_return forStatement104 = default(JavaScriptParser.forStatement_return);
		JavaScriptParser.forInStatement_return forInStatement105 = default(JavaScriptParser.forInStatement_return);


		try { DebugEnterRule(GrammarFileName, "iterationStatement");
		DebugLocation(114, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:115:2: ( doWhileStatement | whileStatement | forStatement | forInStatement )
			int alt47=4;
			try { DebugEnterDecision(47, decisionCanBacktrack[47]);
			switch (input.LA(1))
			{
			case 42:
				{
				alt47=1;
				}
				break;
			case 43:
				{
				alt47=2;
				}
				break;
			case 44:
				{
				int LA47_3 = input.LA(2);

				if ((EvaluatePredicate(synpred63_JavaScript_fragment)))
				{
					alt47=3;
				}
				else if ((true))
				{
					alt47=4;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 47, 3, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 47, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(47); }
			switch (alt47)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:115:4: doWhileStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(115, 4);
				PushFollow(Follow._doWhileStatement_in_iterationStatement599);
				doWhileStatement102=doWhileStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, doWhileStatement102.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:116:4: whileStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(116, 4);
				PushFollow(Follow._whileStatement_in_iterationStatement604);
				whileStatement103=whileStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whileStatement103.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:117:4: forStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(117, 4);
				PushFollow(Follow._forStatement_in_iterationStatement609);
				forStatement104=forStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forStatement104.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:118:4: forInStatement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(118, 4);
				PushFollow(Follow._forInStatement_in_iterationStatement614);
				forInStatement105=forInStatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forInStatement105.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("iterationStatement", 21);
			LeaveRule("iterationStatement", 21);
			Leave_iterationStatement();
			if (state.backtracking > 0) { Memoize(input, 21, iterationStatement_StartIndex); }
		}
		DebugLocation(119, 1);
		} finally { DebugExitRule(GrammarFileName, "iterationStatement"); }
		return retval;

	}
	// $ANTLR end "iterationStatement"

	public class doWhileStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_doWhileStatement();
	partial void Leave_doWhileStatement();

	// $ANTLR start "doWhileStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:121:1: doWhileStatement : 'do' ( LT )* statement ( LT )* 'while' ( LT )* '(' expression ')' ( LT | ';' ) ;
	[GrammarRule("doWhileStatement")]
	private JavaScriptParser.doWhileStatement_return doWhileStatement()
	{
		Enter_doWhileStatement();
		EnterRule("doWhileStatement", 22);
		TraceIn("doWhileStatement", 22);
		JavaScriptParser.doWhileStatement_return retval = new JavaScriptParser.doWhileStatement_return();
		retval.Start = (IToken)input.LT(1);
		int doWhileStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal106=null;
		IToken LT107=null;
		IToken LT109=null;
		IToken string_literal110=null;
		IToken LT111=null;
		IToken char_literal112=null;
		IToken char_literal114=null;
		IToken set115=null;
		JavaScriptParser.statement_return statement108 = default(JavaScriptParser.statement_return);
		JavaScriptParser.expression_return expression113 = default(JavaScriptParser.expression_return);

		object string_literal106_tree=null;
		object LT107_tree=null;
		object LT109_tree=null;
		object string_literal110_tree=null;
		object LT111_tree=null;
		object char_literal112_tree=null;
		object char_literal114_tree=null;
		object set115_tree=null;

		try { DebugEnterRule(GrammarFileName, "doWhileStatement");
		DebugLocation(121, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:122:2: ( 'do' ( LT )* statement ( LT )* 'while' ( LT )* '(' expression ')' ( LT | ';' ) )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:122:4: 'do' ( LT )* statement ( LT )* 'while' ( LT )* '(' expression ')' ( LT | ';' )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(122, 4);
			string_literal106=(IToken)Match(input,42,Follow._42_in_doWhileStatement626); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal106_tree = (object)adaptor.Create(string_literal106);
			adaptor.AddChild(root_0, string_literal106_tree);
			}
			DebugLocation(122, 11);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:122:11: ( LT )*
			try { DebugEnterSubRule(48);
			while (true)
			{
				int alt48=2;
				try { DebugEnterDecision(48, decisionCanBacktrack[48]);
				int LA48_0 = input.LA(1);

				if ((LA48_0==LT))
				{
					alt48=1;
				}


				} finally { DebugExitDecision(48); }
				switch ( alt48 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(122, 11);
					LT107=(IToken)Match(input,LT,Follow._LT_in_doWhileStatement628); if (state.failed) return retval;

					}
					break;

				default:
					goto loop48;
				}
			}

			loop48:
				;

			} finally { DebugExitSubRule(48); }

			DebugLocation(122, 14);
			PushFollow(Follow._statement_in_doWhileStatement632);
			statement108=statement();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement108.Tree);
			DebugLocation(122, 26);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:122:26: ( LT )*
			try { DebugEnterSubRule(49);
			while (true)
			{
				int alt49=2;
				try { DebugEnterDecision(49, decisionCanBacktrack[49]);
				int LA49_0 = input.LA(1);

				if ((LA49_0==LT))
				{
					alt49=1;
				}


				} finally { DebugExitDecision(49); }
				switch ( alt49 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(122, 26);
					LT109=(IToken)Match(input,LT,Follow._LT_in_doWhileStatement634); if (state.failed) return retval;

					}
					break;

				default:
					goto loop49;
				}
			}

			loop49:
				;

			} finally { DebugExitSubRule(49); }

			DebugLocation(122, 29);
			string_literal110=(IToken)Match(input,43,Follow._43_in_doWhileStatement638); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal110_tree = (object)adaptor.Create(string_literal110);
			adaptor.AddChild(root_0, string_literal110_tree);
			}
			DebugLocation(122, 39);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:122:39: ( LT )*
			try { DebugEnterSubRule(50);
			while (true)
			{
				int alt50=2;
				try { DebugEnterDecision(50, decisionCanBacktrack[50]);
				int LA50_0 = input.LA(1);

				if ((LA50_0==LT))
				{
					alt50=1;
				}


				} finally { DebugExitDecision(50); }
				switch ( alt50 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(122, 39);
					LT111=(IToken)Match(input,LT,Follow._LT_in_doWhileStatement640); if (state.failed) return retval;

					}
					break;

				default:
					goto loop50;
				}
			}

			loop50:
				;

			} finally { DebugExitSubRule(50); }

			DebugLocation(122, 42);
			char_literal112=(IToken)Match(input,32,Follow._32_in_doWhileStatement644); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal112_tree = (object)adaptor.Create(char_literal112);
			adaptor.AddChild(root_0, char_literal112_tree);
			}
			DebugLocation(122, 46);
			PushFollow(Follow._expression_in_doWhileStatement646);
			expression113=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression113.Tree);
			DebugLocation(122, 57);
			char_literal114=(IToken)Match(input,34,Follow._34_in_doWhileStatement648); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal114_tree = (object)adaptor.Create(char_literal114);
			adaptor.AddChild(root_0, char_literal114_tree);
			}
			DebugLocation(122, 61);
			set115=(IToken)input.LT(1);
			if (input.LA(1)==LT||input.LA(1)==38)
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("doWhileStatement", 22);
			LeaveRule("doWhileStatement", 22);
			Leave_doWhileStatement();
			if (state.backtracking > 0) { Memoize(input, 22, doWhileStatement_StartIndex); }
		}
		DebugLocation(123, 1);
		} finally { DebugExitRule(GrammarFileName, "doWhileStatement"); }
		return retval;

	}
	// $ANTLR end "doWhileStatement"

	public class whileStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_whileStatement();
	partial void Leave_whileStatement();

	// $ANTLR start "whileStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:125:1: whileStatement : 'while' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement ;
	[GrammarRule("whileStatement")]
	private JavaScriptParser.whileStatement_return whileStatement()
	{
		Enter_whileStatement();
		EnterRule("whileStatement", 23);
		TraceIn("whileStatement", 23);
		JavaScriptParser.whileStatement_return retval = new JavaScriptParser.whileStatement_return();
		retval.Start = (IToken)input.LT(1);
		int whileStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal116=null;
		IToken LT117=null;
		IToken char_literal118=null;
		IToken LT119=null;
		IToken LT121=null;
		IToken char_literal122=null;
		IToken LT123=null;
		JavaScriptParser.expression_return expression120 = default(JavaScriptParser.expression_return);
		JavaScriptParser.statement_return statement124 = default(JavaScriptParser.statement_return);

		object string_literal116_tree=null;
		object LT117_tree=null;
		object char_literal118_tree=null;
		object LT119_tree=null;
		object LT121_tree=null;
		object char_literal122_tree=null;
		object LT123_tree=null;

		try { DebugEnterRule(GrammarFileName, "whileStatement");
		DebugLocation(125, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:126:2: ( 'while' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:126:4: 'while' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(126, 4);
			string_literal116=(IToken)Match(input,43,Follow._43_in_whileStatement669); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal116_tree = (object)adaptor.Create(string_literal116);
			adaptor.AddChild(root_0, string_literal116_tree);
			}
			DebugLocation(126, 14);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:126:14: ( LT )*
			try { DebugEnterSubRule(51);
			while (true)
			{
				int alt51=2;
				try { DebugEnterDecision(51, decisionCanBacktrack[51]);
				int LA51_0 = input.LA(1);

				if ((LA51_0==LT))
				{
					alt51=1;
				}


				} finally { DebugExitDecision(51); }
				switch ( alt51 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(126, 14);
					LT117=(IToken)Match(input,LT,Follow._LT_in_whileStatement671); if (state.failed) return retval;

					}
					break;

				default:
					goto loop51;
				}
			}

			loop51:
				;

			} finally { DebugExitSubRule(51); }

			DebugLocation(126, 17);
			char_literal118=(IToken)Match(input,32,Follow._32_in_whileStatement675); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal118_tree = (object)adaptor.Create(char_literal118);
			adaptor.AddChild(root_0, char_literal118_tree);
			}
			DebugLocation(126, 23);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:126:23: ( LT )*
			try { DebugEnterSubRule(52);
			while (true)
			{
				int alt52=2;
				try { DebugEnterDecision(52, decisionCanBacktrack[52]);
				int LA52_0 = input.LA(1);

				if ((LA52_0==LT))
				{
					alt52=1;
				}


				} finally { DebugExitDecision(52); }
				switch ( alt52 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(126, 23);
					LT119=(IToken)Match(input,LT,Follow._LT_in_whileStatement677); if (state.failed) return retval;

					}
					break;

				default:
					goto loop52;
				}
			}

			loop52:
				;

			} finally { DebugExitSubRule(52); }

			DebugLocation(126, 26);
			PushFollow(Follow._expression_in_whileStatement681);
			expression120=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression120.Tree);
			DebugLocation(126, 39);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:126:39: ( LT )*
			try { DebugEnterSubRule(53);
			while (true)
			{
				int alt53=2;
				try { DebugEnterDecision(53, decisionCanBacktrack[53]);
				int LA53_0 = input.LA(1);

				if ((LA53_0==LT))
				{
					alt53=1;
				}


				} finally { DebugExitDecision(53); }
				switch ( alt53 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(126, 39);
					LT121=(IToken)Match(input,LT,Follow._LT_in_whileStatement683); if (state.failed) return retval;

					}
					break;

				default:
					goto loop53;
				}
			}

			loop53:
				;

			} finally { DebugExitSubRule(53); }

			DebugLocation(126, 42);
			char_literal122=(IToken)Match(input,34,Follow._34_in_whileStatement687); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal122_tree = (object)adaptor.Create(char_literal122);
			adaptor.AddChild(root_0, char_literal122_tree);
			}
			DebugLocation(126, 48);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:126:48: ( LT )*
			try { DebugEnterSubRule(54);
			while (true)
			{
				int alt54=2;
				try { DebugEnterDecision(54, decisionCanBacktrack[54]);
				int LA54_0 = input.LA(1);

				if ((LA54_0==LT))
				{
					alt54=1;
				}


				} finally { DebugExitDecision(54); }
				switch ( alt54 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(126, 48);
					LT123=(IToken)Match(input,LT,Follow._LT_in_whileStatement689); if (state.failed) return retval;

					}
					break;

				default:
					goto loop54;
				}
			}

			loop54:
				;

			} finally { DebugExitSubRule(54); }

			DebugLocation(126, 51);
			PushFollow(Follow._statement_in_whileStatement693);
			statement124=statement();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement124.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("whileStatement", 23);
			LeaveRule("whileStatement", 23);
			Leave_whileStatement();
			if (state.backtracking > 0) { Memoize(input, 23, whileStatement_StartIndex); }
		}
		DebugLocation(127, 1);
		} finally { DebugExitRule(GrammarFileName, "whileStatement"); }
		return retval;

	}
	// $ANTLR end "whileStatement"

	public class forStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_forStatement();
	partial void Leave_forStatement();

	// $ANTLR start "forStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:129:1: forStatement : 'for' ( LT )* '(' ( ( LT )* forStatementInitialiserPart )? ( LT )* ';' ( ( LT )* expression )? ( LT )* ';' ( ( LT )* expression )? ( LT )* ')' ( LT )* statement ;
	[GrammarRule("forStatement")]
	private JavaScriptParser.forStatement_return forStatement()
	{
		Enter_forStatement();
		EnterRule("forStatement", 24);
		TraceIn("forStatement", 24);
		JavaScriptParser.forStatement_return retval = new JavaScriptParser.forStatement_return();
		retval.Start = (IToken)input.LT(1);
		int forStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal125=null;
		IToken LT126=null;
		IToken char_literal127=null;
		IToken LT128=null;
		IToken LT130=null;
		IToken char_literal131=null;
		IToken LT132=null;
		IToken LT134=null;
		IToken char_literal135=null;
		IToken LT136=null;
		IToken LT138=null;
		IToken char_literal139=null;
		IToken LT140=null;
		JavaScriptParser.forStatementInitialiserPart_return forStatementInitialiserPart129 = default(JavaScriptParser.forStatementInitialiserPart_return);
		JavaScriptParser.expression_return expression133 = default(JavaScriptParser.expression_return);
		JavaScriptParser.expression_return expression137 = default(JavaScriptParser.expression_return);
		JavaScriptParser.statement_return statement141 = default(JavaScriptParser.statement_return);

		object string_literal125_tree=null;
		object LT126_tree=null;
		object char_literal127_tree=null;
		object LT128_tree=null;
		object LT130_tree=null;
		object char_literal131_tree=null;
		object LT132_tree=null;
		object LT134_tree=null;
		object char_literal135_tree=null;
		object LT136_tree=null;
		object LT138_tree=null;
		object char_literal139_tree=null;
		object LT140_tree=null;

		try { DebugEnterRule(GrammarFileName, "forStatement");
		DebugLocation(129, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:2: ( 'for' ( LT )* '(' ( ( LT )* forStatementInitialiserPart )? ( LT )* ';' ( ( LT )* expression )? ( LT )* ';' ( ( LT )* expression )? ( LT )* ')' ( LT )* statement )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:4: 'for' ( LT )* '(' ( ( LT )* forStatementInitialiserPart )? ( LT )* ';' ( ( LT )* expression )? ( LT )* ';' ( ( LT )* expression )? ( LT )* ')' ( LT )* statement
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(130, 4);
			string_literal125=(IToken)Match(input,44,Follow._44_in_forStatement705); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal125_tree = (object)adaptor.Create(string_literal125);
			adaptor.AddChild(root_0, string_literal125_tree);
			}
			DebugLocation(130, 12);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:12: ( LT )*
			try { DebugEnterSubRule(55);
			while (true)
			{
				int alt55=2;
				try { DebugEnterDecision(55, decisionCanBacktrack[55]);
				int LA55_0 = input.LA(1);

				if ((LA55_0==LT))
				{
					alt55=1;
				}


				} finally { DebugExitDecision(55); }
				switch ( alt55 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(130, 12);
					LT126=(IToken)Match(input,LT,Follow._LT_in_forStatement707); if (state.failed) return retval;

					}
					break;

				default:
					goto loop55;
				}
			}

			loop55:
				;

			} finally { DebugExitSubRule(55); }

			DebugLocation(130, 15);
			char_literal127=(IToken)Match(input,32,Follow._32_in_forStatement711); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal127_tree = (object)adaptor.Create(char_literal127);
			adaptor.AddChild(root_0, char_literal127_tree);
			}
			DebugLocation(130, 19);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:19: ( ( LT )* forStatementInitialiserPart )?
			int alt57=2;
			try { DebugEnterSubRule(57);
			try { DebugEnterDecision(57, decisionCanBacktrack[57]);
			try
			{
				alt57 = dfa57.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(57); }
			switch (alt57)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:20: ( LT )* forStatementInitialiserPart
				{
				DebugLocation(130, 22);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:22: ( LT )*
				try { DebugEnterSubRule(56);
				while (true)
				{
					int alt56=2;
					try { DebugEnterDecision(56, decisionCanBacktrack[56]);
					int LA56_0 = input.LA(1);

					if ((LA56_0==LT))
					{
						alt56=1;
					}


					} finally { DebugExitDecision(56); }
					switch ( alt56 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(130, 22);
						LT128=(IToken)Match(input,LT,Follow._LT_in_forStatement714); if (state.failed) return retval;

						}
						break;

					default:
						goto loop56;
					}
				}

				loop56:
					;

				} finally { DebugExitSubRule(56); }

				DebugLocation(130, 25);
				PushFollow(Follow._forStatementInitialiserPart_in_forStatement718);
				forStatementInitialiserPart129=forStatementInitialiserPart();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forStatementInitialiserPart129.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(57); }

			DebugLocation(130, 57);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:57: ( LT )*
			try { DebugEnterSubRule(58);
			while (true)
			{
				int alt58=2;
				try { DebugEnterDecision(58, decisionCanBacktrack[58]);
				int LA58_0 = input.LA(1);

				if ((LA58_0==LT))
				{
					alt58=1;
				}


				} finally { DebugExitDecision(58); }
				switch ( alt58 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(130, 57);
					LT130=(IToken)Match(input,LT,Follow._LT_in_forStatement722); if (state.failed) return retval;

					}
					break;

				default:
					goto loop58;
				}
			}

			loop58:
				;

			} finally { DebugExitSubRule(58); }

			DebugLocation(130, 60);
			char_literal131=(IToken)Match(input,38,Follow._38_in_forStatement726); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal131_tree = (object)adaptor.Create(char_literal131);
			adaptor.AddChild(root_0, char_literal131_tree);
			}
			DebugLocation(130, 64);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:64: ( ( LT )* expression )?
			int alt60=2;
			try { DebugEnterSubRule(60);
			try { DebugEnterDecision(60, decisionCanBacktrack[60]);
			try
			{
				alt60 = dfa60.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(60); }
			switch (alt60)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:65: ( LT )* expression
				{
				DebugLocation(130, 67);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:67: ( LT )*
				try { DebugEnterSubRule(59);
				while (true)
				{
					int alt59=2;
					try { DebugEnterDecision(59, decisionCanBacktrack[59]);
					int LA59_0 = input.LA(1);

					if ((LA59_0==LT))
					{
						alt59=1;
					}


					} finally { DebugExitDecision(59); }
					switch ( alt59 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(130, 67);
						LT132=(IToken)Match(input,LT,Follow._LT_in_forStatement729); if (state.failed) return retval;

						}
						break;

					default:
						goto loop59;
					}
				}

				loop59:
					;

				} finally { DebugExitSubRule(59); }

				DebugLocation(130, 70);
				PushFollow(Follow._expression_in_forStatement733);
				expression133=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression133.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(60); }

			DebugLocation(130, 85);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:85: ( LT )*
			try { DebugEnterSubRule(61);
			while (true)
			{
				int alt61=2;
				try { DebugEnterDecision(61, decisionCanBacktrack[61]);
				int LA61_0 = input.LA(1);

				if ((LA61_0==LT))
				{
					alt61=1;
				}


				} finally { DebugExitDecision(61); }
				switch ( alt61 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(130, 85);
					LT134=(IToken)Match(input,LT,Follow._LT_in_forStatement737); if (state.failed) return retval;

					}
					break;

				default:
					goto loop61;
				}
			}

			loop61:
				;

			} finally { DebugExitSubRule(61); }

			DebugLocation(130, 88);
			char_literal135=(IToken)Match(input,38,Follow._38_in_forStatement741); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal135_tree = (object)adaptor.Create(char_literal135);
			adaptor.AddChild(root_0, char_literal135_tree);
			}
			DebugLocation(130, 92);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:92: ( ( LT )* expression )?
			int alt63=2;
			try { DebugEnterSubRule(63);
			try { DebugEnterDecision(63, decisionCanBacktrack[63]);
			try
			{
				alt63 = dfa63.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(63); }
			switch (alt63)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:93: ( LT )* expression
				{
				DebugLocation(130, 95);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:95: ( LT )*
				try { DebugEnterSubRule(62);
				while (true)
				{
					int alt62=2;
					try { DebugEnterDecision(62, decisionCanBacktrack[62]);
					int LA62_0 = input.LA(1);

					if ((LA62_0==LT))
					{
						alt62=1;
					}


					} finally { DebugExitDecision(62); }
					switch ( alt62 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(130, 95);
						LT136=(IToken)Match(input,LT,Follow._LT_in_forStatement744); if (state.failed) return retval;

						}
						break;

					default:
						goto loop62;
					}
				}

				loop62:
					;

				} finally { DebugExitSubRule(62); }

				DebugLocation(130, 98);
				PushFollow(Follow._expression_in_forStatement748);
				expression137=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression137.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(63); }

			DebugLocation(130, 113);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:113: ( LT )*
			try { DebugEnterSubRule(64);
			while (true)
			{
				int alt64=2;
				try { DebugEnterDecision(64, decisionCanBacktrack[64]);
				int LA64_0 = input.LA(1);

				if ((LA64_0==LT))
				{
					alt64=1;
				}


				} finally { DebugExitDecision(64); }
				switch ( alt64 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(130, 113);
					LT138=(IToken)Match(input,LT,Follow._LT_in_forStatement752); if (state.failed) return retval;

					}
					break;

				default:
					goto loop64;
				}
			}

			loop64:
				;

			} finally { DebugExitSubRule(64); }

			DebugLocation(130, 116);
			char_literal139=(IToken)Match(input,34,Follow._34_in_forStatement756); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal139_tree = (object)adaptor.Create(char_literal139);
			adaptor.AddChild(root_0, char_literal139_tree);
			}
			DebugLocation(130, 122);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:130:122: ( LT )*
			try { DebugEnterSubRule(65);
			while (true)
			{
				int alt65=2;
				try { DebugEnterDecision(65, decisionCanBacktrack[65]);
				int LA65_0 = input.LA(1);

				if ((LA65_0==LT))
				{
					alt65=1;
				}


				} finally { DebugExitDecision(65); }
				switch ( alt65 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(130, 122);
					LT140=(IToken)Match(input,LT,Follow._LT_in_forStatement758); if (state.failed) return retval;

					}
					break;

				default:
					goto loop65;
				}
			}

			loop65:
				;

			} finally { DebugExitSubRule(65); }

			DebugLocation(130, 125);
			PushFollow(Follow._statement_in_forStatement762);
			statement141=statement();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement141.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("forStatement", 24);
			LeaveRule("forStatement", 24);
			Leave_forStatement();
			if (state.backtracking > 0) { Memoize(input, 24, forStatement_StartIndex); }
		}
		DebugLocation(131, 1);
		} finally { DebugExitRule(GrammarFileName, "forStatement"); }
		return retval;

	}
	// $ANTLR end "forStatement"

	public class forStatementInitialiserPart_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_forStatementInitialiserPart();
	partial void Leave_forStatementInitialiserPart();

	// $ANTLR start "forStatementInitialiserPart"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:133:1: forStatementInitialiserPart : ( expressionNoIn | 'var' ( LT )* variableDeclarationListNoIn );
	[GrammarRule("forStatementInitialiserPart")]
	private JavaScriptParser.forStatementInitialiserPart_return forStatementInitialiserPart()
	{
		Enter_forStatementInitialiserPart();
		EnterRule("forStatementInitialiserPart", 25);
		TraceIn("forStatementInitialiserPart", 25);
		JavaScriptParser.forStatementInitialiserPart_return retval = new JavaScriptParser.forStatementInitialiserPart_return();
		retval.Start = (IToken)input.LT(1);
		int forStatementInitialiserPart_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal143=null;
		IToken LT144=null;
		JavaScriptParser.expressionNoIn_return expressionNoIn142 = default(JavaScriptParser.expressionNoIn_return);
		JavaScriptParser.variableDeclarationListNoIn_return variableDeclarationListNoIn145 = default(JavaScriptParser.variableDeclarationListNoIn_return);

		object string_literal143_tree=null;
		object LT144_tree=null;

		try { DebugEnterRule(GrammarFileName, "forStatementInitialiserPart");
		DebugLocation(133, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:134:2: ( expressionNoIn | 'var' ( LT )* variableDeclarationListNoIn )
			int alt67=2;
			try { DebugEnterDecision(67, decisionCanBacktrack[67]);
			int LA67_0 = input.LA(1);

			if (((LA67_0>=Identifier && LA67_0<=NumericLiteral)||(LA67_0>=31 && LA67_0<=32)||LA67_0==35||(LA67_0>=58 && LA67_0<=59)||(LA67_0>=91 && LA67_0<=92)||(LA67_0>=96 && LA67_0<=106)))
			{
				alt67=1;
			}
			else if ((LA67_0==37))
			{
				alt67=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 67, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(67); }
			switch (alt67)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:134:4: expressionNoIn
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(134, 4);
				PushFollow(Follow._expressionNoIn_in_forStatementInitialiserPart774);
				expressionNoIn142=expressionNoIn();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressionNoIn142.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:135:4: 'var' ( LT )* variableDeclarationListNoIn
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(135, 4);
				string_literal143=(IToken)Match(input,37,Follow._37_in_forStatementInitialiserPart779); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				string_literal143_tree = (object)adaptor.Create(string_literal143);
				adaptor.AddChild(root_0, string_literal143_tree);
				}
				DebugLocation(135, 12);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:135:12: ( LT )*
				try { DebugEnterSubRule(66);
				while (true)
				{
					int alt66=2;
					try { DebugEnterDecision(66, decisionCanBacktrack[66]);
					int LA66_0 = input.LA(1);

					if ((LA66_0==LT))
					{
						alt66=1;
					}


					} finally { DebugExitDecision(66); }
					switch ( alt66 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(135, 12);
						LT144=(IToken)Match(input,LT,Follow._LT_in_forStatementInitialiserPart781); if (state.failed) return retval;

						}
						break;

					default:
						goto loop66;
					}
				}

				loop66:
					;

				} finally { DebugExitSubRule(66); }

				DebugLocation(135, 15);
				PushFollow(Follow._variableDeclarationListNoIn_in_forStatementInitialiserPart785);
				variableDeclarationListNoIn145=variableDeclarationListNoIn();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclarationListNoIn145.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("forStatementInitialiserPart", 25);
			LeaveRule("forStatementInitialiserPart", 25);
			Leave_forStatementInitialiserPart();
			if (state.backtracking > 0) { Memoize(input, 25, forStatementInitialiserPart_StartIndex); }
		}
		DebugLocation(136, 1);
		} finally { DebugExitRule(GrammarFileName, "forStatementInitialiserPart"); }
		return retval;

	}
	// $ANTLR end "forStatementInitialiserPart"

	public class forInStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_forInStatement();
	partial void Leave_forInStatement();

	// $ANTLR start "forInStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:138:1: forInStatement : 'for' ( LT )* '(' ( LT )* forInStatementInitialiserPart ( LT )* 'in' ( LT )* expression ( LT )* ')' ( LT )* statement ;
	[GrammarRule("forInStatement")]
	private JavaScriptParser.forInStatement_return forInStatement()
	{
		Enter_forInStatement();
		EnterRule("forInStatement", 26);
		TraceIn("forInStatement", 26);
		JavaScriptParser.forInStatement_return retval = new JavaScriptParser.forInStatement_return();
		retval.Start = (IToken)input.LT(1);
		int forInStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal146=null;
		IToken LT147=null;
		IToken char_literal148=null;
		IToken LT149=null;
		IToken LT151=null;
		IToken string_literal152=null;
		IToken LT153=null;
		IToken LT155=null;
		IToken char_literal156=null;
		IToken LT157=null;
		JavaScriptParser.forInStatementInitialiserPart_return forInStatementInitialiserPart150 = default(JavaScriptParser.forInStatementInitialiserPart_return);
		JavaScriptParser.expression_return expression154 = default(JavaScriptParser.expression_return);
		JavaScriptParser.statement_return statement158 = default(JavaScriptParser.statement_return);

		object string_literal146_tree=null;
		object LT147_tree=null;
		object char_literal148_tree=null;
		object LT149_tree=null;
		object LT151_tree=null;
		object string_literal152_tree=null;
		object LT153_tree=null;
		object LT155_tree=null;
		object char_literal156_tree=null;
		object LT157_tree=null;

		try { DebugEnterRule(GrammarFileName, "forInStatement");
		DebugLocation(138, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:139:2: ( 'for' ( LT )* '(' ( LT )* forInStatementInitialiserPart ( LT )* 'in' ( LT )* expression ( LT )* ')' ( LT )* statement )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:139:4: 'for' ( LT )* '(' ( LT )* forInStatementInitialiserPart ( LT )* 'in' ( LT )* expression ( LT )* ')' ( LT )* statement
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(139, 4);
			string_literal146=(IToken)Match(input,44,Follow._44_in_forInStatement797); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal146_tree = (object)adaptor.Create(string_literal146);
			adaptor.AddChild(root_0, string_literal146_tree);
			}
			DebugLocation(139, 12);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:139:12: ( LT )*
			try { DebugEnterSubRule(68);
			while (true)
			{
				int alt68=2;
				try { DebugEnterDecision(68, decisionCanBacktrack[68]);
				int LA68_0 = input.LA(1);

				if ((LA68_0==LT))
				{
					alt68=1;
				}


				} finally { DebugExitDecision(68); }
				switch ( alt68 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(139, 12);
					LT147=(IToken)Match(input,LT,Follow._LT_in_forInStatement799); if (state.failed) return retval;

					}
					break;

				default:
					goto loop68;
				}
			}

			loop68:
				;

			} finally { DebugExitSubRule(68); }

			DebugLocation(139, 15);
			char_literal148=(IToken)Match(input,32,Follow._32_in_forInStatement803); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal148_tree = (object)adaptor.Create(char_literal148);
			adaptor.AddChild(root_0, char_literal148_tree);
			}
			DebugLocation(139, 21);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:139:21: ( LT )*
			try { DebugEnterSubRule(69);
			while (true)
			{
				int alt69=2;
				try { DebugEnterDecision(69, decisionCanBacktrack[69]);
				int LA69_0 = input.LA(1);

				if ((LA69_0==LT))
				{
					alt69=1;
				}


				} finally { DebugExitDecision(69); }
				switch ( alt69 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(139, 21);
					LT149=(IToken)Match(input,LT,Follow._LT_in_forInStatement805); if (state.failed) return retval;

					}
					break;

				default:
					goto loop69;
				}
			}

			loop69:
				;

			} finally { DebugExitSubRule(69); }

			DebugLocation(139, 24);
			PushFollow(Follow._forInStatementInitialiserPart_in_forInStatement809);
			forInStatementInitialiserPart150=forInStatementInitialiserPart();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forInStatementInitialiserPart150.Tree);
			DebugLocation(139, 56);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:139:56: ( LT )*
			try { DebugEnterSubRule(70);
			while (true)
			{
				int alt70=2;
				try { DebugEnterDecision(70, decisionCanBacktrack[70]);
				int LA70_0 = input.LA(1);

				if ((LA70_0==LT))
				{
					alt70=1;
				}


				} finally { DebugExitDecision(70); }
				switch ( alt70 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(139, 56);
					LT151=(IToken)Match(input,LT,Follow._LT_in_forInStatement811); if (state.failed) return retval;

					}
					break;

				default:
					goto loop70;
				}
			}

			loop70:
				;

			} finally { DebugExitSubRule(70); }

			DebugLocation(139, 59);
			string_literal152=(IToken)Match(input,45,Follow._45_in_forInStatement815); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal152_tree = (object)adaptor.Create(string_literal152);
			adaptor.AddChild(root_0, string_literal152_tree);
			}
			DebugLocation(139, 66);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:139:66: ( LT )*
			try { DebugEnterSubRule(71);
			while (true)
			{
				int alt71=2;
				try { DebugEnterDecision(71, decisionCanBacktrack[71]);
				int LA71_0 = input.LA(1);

				if ((LA71_0==LT))
				{
					alt71=1;
				}


				} finally { DebugExitDecision(71); }
				switch ( alt71 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(139, 66);
					LT153=(IToken)Match(input,LT,Follow._LT_in_forInStatement817); if (state.failed) return retval;

					}
					break;

				default:
					goto loop71;
				}
			}

			loop71:
				;

			} finally { DebugExitSubRule(71); }

			DebugLocation(139, 69);
			PushFollow(Follow._expression_in_forInStatement821);
			expression154=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression154.Tree);
			DebugLocation(139, 82);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:139:82: ( LT )*
			try { DebugEnterSubRule(72);
			while (true)
			{
				int alt72=2;
				try { DebugEnterDecision(72, decisionCanBacktrack[72]);
				int LA72_0 = input.LA(1);

				if ((LA72_0==LT))
				{
					alt72=1;
				}


				} finally { DebugExitDecision(72); }
				switch ( alt72 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(139, 82);
					LT155=(IToken)Match(input,LT,Follow._LT_in_forInStatement823); if (state.failed) return retval;

					}
					break;

				default:
					goto loop72;
				}
			}

			loop72:
				;

			} finally { DebugExitSubRule(72); }

			DebugLocation(139, 85);
			char_literal156=(IToken)Match(input,34,Follow._34_in_forInStatement827); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal156_tree = (object)adaptor.Create(char_literal156);
			adaptor.AddChild(root_0, char_literal156_tree);
			}
			DebugLocation(139, 91);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:139:91: ( LT )*
			try { DebugEnterSubRule(73);
			while (true)
			{
				int alt73=2;
				try { DebugEnterDecision(73, decisionCanBacktrack[73]);
				int LA73_0 = input.LA(1);

				if ((LA73_0==LT))
				{
					alt73=1;
				}


				} finally { DebugExitDecision(73); }
				switch ( alt73 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(139, 91);
					LT157=(IToken)Match(input,LT,Follow._LT_in_forInStatement829); if (state.failed) return retval;

					}
					break;

				default:
					goto loop73;
				}
			}

			loop73:
				;

			} finally { DebugExitSubRule(73); }

			DebugLocation(139, 94);
			PushFollow(Follow._statement_in_forInStatement833);
			statement158=statement();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement158.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("forInStatement", 26);
			LeaveRule("forInStatement", 26);
			Leave_forInStatement();
			if (state.backtracking > 0) { Memoize(input, 26, forInStatement_StartIndex); }
		}
		DebugLocation(140, 1);
		} finally { DebugExitRule(GrammarFileName, "forInStatement"); }
		return retval;

	}
	// $ANTLR end "forInStatement"

	public class forInStatementInitialiserPart_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_forInStatementInitialiserPart();
	partial void Leave_forInStatementInitialiserPart();

	// $ANTLR start "forInStatementInitialiserPart"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:142:1: forInStatementInitialiserPart : ( leftHandSideExpression | 'var' ( LT )* variableDeclarationNoIn );
	[GrammarRule("forInStatementInitialiserPart")]
	private JavaScriptParser.forInStatementInitialiserPart_return forInStatementInitialiserPart()
	{
		Enter_forInStatementInitialiserPart();
		EnterRule("forInStatementInitialiserPart", 27);
		TraceIn("forInStatementInitialiserPart", 27);
		JavaScriptParser.forInStatementInitialiserPart_return retval = new JavaScriptParser.forInStatementInitialiserPart_return();
		retval.Start = (IToken)input.LT(1);
		int forInStatementInitialiserPart_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal160=null;
		IToken LT161=null;
		JavaScriptParser.leftHandSideExpression_return leftHandSideExpression159 = default(JavaScriptParser.leftHandSideExpression_return);
		JavaScriptParser.variableDeclarationNoIn_return variableDeclarationNoIn162 = default(JavaScriptParser.variableDeclarationNoIn_return);

		object string_literal160_tree=null;
		object LT161_tree=null;

		try { DebugEnterRule(GrammarFileName, "forInStatementInitialiserPart");
		DebugLocation(142, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:143:2: ( leftHandSideExpression | 'var' ( LT )* variableDeclarationNoIn )
			int alt75=2;
			try { DebugEnterDecision(75, decisionCanBacktrack[75]);
			int LA75_0 = input.LA(1);

			if (((LA75_0>=Identifier && LA75_0<=NumericLiteral)||(LA75_0>=31 && LA75_0<=32)||LA75_0==35||(LA75_0>=58 && LA75_0<=59)||(LA75_0>=103 && LA75_0<=106)))
			{
				alt75=1;
			}
			else if ((LA75_0==37))
			{
				alt75=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 75, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(75); }
			switch (alt75)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:143:4: leftHandSideExpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(143, 4);
				PushFollow(Follow._leftHandSideExpression_in_forInStatementInitialiserPart845);
				leftHandSideExpression159=leftHandSideExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftHandSideExpression159.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:144:4: 'var' ( LT )* variableDeclarationNoIn
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(144, 4);
				string_literal160=(IToken)Match(input,37,Follow._37_in_forInStatementInitialiserPart850); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				string_literal160_tree = (object)adaptor.Create(string_literal160);
				adaptor.AddChild(root_0, string_literal160_tree);
				}
				DebugLocation(144, 12);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:144:12: ( LT )*
				try { DebugEnterSubRule(74);
				while (true)
				{
					int alt74=2;
					try { DebugEnterDecision(74, decisionCanBacktrack[74]);
					int LA74_0 = input.LA(1);

					if ((LA74_0==LT))
					{
						alt74=1;
					}


					} finally { DebugExitDecision(74); }
					switch ( alt74 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(144, 12);
						LT161=(IToken)Match(input,LT,Follow._LT_in_forInStatementInitialiserPart852); if (state.failed) return retval;

						}
						break;

					default:
						goto loop74;
					}
				}

				loop74:
					;

				} finally { DebugExitSubRule(74); }

				DebugLocation(144, 15);
				PushFollow(Follow._variableDeclarationNoIn_in_forInStatementInitialiserPart856);
				variableDeclarationNoIn162=variableDeclarationNoIn();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclarationNoIn162.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("forInStatementInitialiserPart", 27);
			LeaveRule("forInStatementInitialiserPart", 27);
			Leave_forInStatementInitialiserPart();
			if (state.backtracking > 0) { Memoize(input, 27, forInStatementInitialiserPart_StartIndex); }
		}
		DebugLocation(145, 1);
		} finally { DebugExitRule(GrammarFileName, "forInStatementInitialiserPart"); }
		return retval;

	}
	// $ANTLR end "forInStatementInitialiserPart"

	public class continueStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_continueStatement();
	partial void Leave_continueStatement();

	// $ANTLR start "continueStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:147:1: continueStatement : 'continue' ( Identifier )? ( LT | ';' ) ;
	[GrammarRule("continueStatement")]
	private JavaScriptParser.continueStatement_return continueStatement()
	{
		Enter_continueStatement();
		EnterRule("continueStatement", 28);
		TraceIn("continueStatement", 28);
		JavaScriptParser.continueStatement_return retval = new JavaScriptParser.continueStatement_return();
		retval.Start = (IToken)input.LT(1);
		int continueStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal163=null;
		IToken Identifier164=null;
		IToken set165=null;

		object string_literal163_tree=null;
		object Identifier164_tree=null;
		object set165_tree=null;

		try { DebugEnterRule(GrammarFileName, "continueStatement");
		DebugLocation(147, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:148:2: ( 'continue' ( Identifier )? ( LT | ';' ) )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:148:4: 'continue' ( Identifier )? ( LT | ';' )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(148, 4);
			string_literal163=(IToken)Match(input,46,Follow._46_in_continueStatement867); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal163_tree = (object)adaptor.Create(string_literal163);
			adaptor.AddChild(root_0, string_literal163_tree);
			}
			DebugLocation(148, 15);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:148:15: ( Identifier )?
			int alt76=2;
			try { DebugEnterSubRule(76);
			try { DebugEnterDecision(76, decisionCanBacktrack[76]);
			int LA76_0 = input.LA(1);

			if ((LA76_0==Identifier))
			{
				alt76=1;
			}
			} finally { DebugExitDecision(76); }
			switch (alt76)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: Identifier
				{
				DebugLocation(148, 15);
				Identifier164=(IToken)Match(input,Identifier,Follow._Identifier_in_continueStatement869); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				Identifier164_tree = (object)adaptor.Create(Identifier164);
				adaptor.AddChild(root_0, Identifier164_tree);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(76); }

			DebugLocation(148, 27);
			set165=(IToken)input.LT(1);
			if (input.LA(1)==LT||input.LA(1)==38)
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("continueStatement", 28);
			LeaveRule("continueStatement", 28);
			Leave_continueStatement();
			if (state.backtracking > 0) { Memoize(input, 28, continueStatement_StartIndex); }
		}
		DebugLocation(149, 1);
		} finally { DebugExitRule(GrammarFileName, "continueStatement"); }
		return retval;

	}
	// $ANTLR end "continueStatement"

	public class breakStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_breakStatement();
	partial void Leave_breakStatement();

	// $ANTLR start "breakStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:151:1: breakStatement : 'break' ( Identifier )? ( LT | ';' ) ;
	[GrammarRule("breakStatement")]
	private JavaScriptParser.breakStatement_return breakStatement()
	{
		Enter_breakStatement();
		EnterRule("breakStatement", 29);
		TraceIn("breakStatement", 29);
		JavaScriptParser.breakStatement_return retval = new JavaScriptParser.breakStatement_return();
		retval.Start = (IToken)input.LT(1);
		int breakStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal166=null;
		IToken Identifier167=null;
		IToken set168=null;

		object string_literal166_tree=null;
		object Identifier167_tree=null;
		object set168_tree=null;

		try { DebugEnterRule(GrammarFileName, "breakStatement");
		DebugLocation(151, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:152:2: ( 'break' ( Identifier )? ( LT | ';' ) )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:152:4: 'break' ( Identifier )? ( LT | ';' )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(152, 4);
			string_literal166=(IToken)Match(input,47,Follow._47_in_breakStatement890); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal166_tree = (object)adaptor.Create(string_literal166);
			adaptor.AddChild(root_0, string_literal166_tree);
			}
			DebugLocation(152, 12);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:152:12: ( Identifier )?
			int alt77=2;
			try { DebugEnterSubRule(77);
			try { DebugEnterDecision(77, decisionCanBacktrack[77]);
			int LA77_0 = input.LA(1);

			if ((LA77_0==Identifier))
			{
				alt77=1;
			}
			} finally { DebugExitDecision(77); }
			switch (alt77)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: Identifier
				{
				DebugLocation(152, 12);
				Identifier167=(IToken)Match(input,Identifier,Follow._Identifier_in_breakStatement892); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				Identifier167_tree = (object)adaptor.Create(Identifier167);
				adaptor.AddChild(root_0, Identifier167_tree);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(77); }

			DebugLocation(152, 24);
			set168=(IToken)input.LT(1);
			if (input.LA(1)==LT||input.LA(1)==38)
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("breakStatement", 29);
			LeaveRule("breakStatement", 29);
			Leave_breakStatement();
			if (state.backtracking > 0) { Memoize(input, 29, breakStatement_StartIndex); }
		}
		DebugLocation(153, 1);
		} finally { DebugExitRule(GrammarFileName, "breakStatement"); }
		return retval;

	}
	// $ANTLR end "breakStatement"

	public class returnStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_returnStatement();
	partial void Leave_returnStatement();

	// $ANTLR start "returnStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:155:1: returnStatement : 'return' ( expression )? ( LT | ';' ) ;
	[GrammarRule("returnStatement")]
	private JavaScriptParser.returnStatement_return returnStatement()
	{
		Enter_returnStatement();
		EnterRule("returnStatement", 30);
		TraceIn("returnStatement", 30);
		JavaScriptParser.returnStatement_return retval = new JavaScriptParser.returnStatement_return();
		retval.Start = (IToken)input.LT(1);
		int returnStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal169=null;
		IToken set171=null;
		JavaScriptParser.expression_return expression170 = default(JavaScriptParser.expression_return);

		object string_literal169_tree=null;
		object set171_tree=null;

		try { DebugEnterRule(GrammarFileName, "returnStatement");
		DebugLocation(155, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:156:2: ( 'return' ( expression )? ( LT | ';' ) )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:156:4: 'return' ( expression )? ( LT | ';' )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(156, 4);
			string_literal169=(IToken)Match(input,48,Follow._48_in_returnStatement913); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal169_tree = (object)adaptor.Create(string_literal169);
			adaptor.AddChild(root_0, string_literal169_tree);
			}
			DebugLocation(156, 13);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:156:13: ( expression )?
			int alt78=2;
			try { DebugEnterSubRule(78);
			try { DebugEnterDecision(78, decisionCanBacktrack[78]);
			int LA78_0 = input.LA(1);

			if (((LA78_0>=Identifier && LA78_0<=NumericLiteral)||(LA78_0>=31 && LA78_0<=32)||LA78_0==35||(LA78_0>=58 && LA78_0<=59)||(LA78_0>=91 && LA78_0<=92)||(LA78_0>=96 && LA78_0<=106)))
			{
				alt78=1;
			}
			} finally { DebugExitDecision(78); }
			switch (alt78)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: expression
				{
				DebugLocation(156, 13);
				PushFollow(Follow._expression_in_returnStatement915);
				expression170=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression170.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(78); }

			DebugLocation(156, 25);
			set171=(IToken)input.LT(1);
			if (input.LA(1)==LT||input.LA(1)==38)
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("returnStatement", 30);
			LeaveRule("returnStatement", 30);
			Leave_returnStatement();
			if (state.backtracking > 0) { Memoize(input, 30, returnStatement_StartIndex); }
		}
		DebugLocation(157, 1);
		} finally { DebugExitRule(GrammarFileName, "returnStatement"); }
		return retval;

	}
	// $ANTLR end "returnStatement"

	public class withStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_withStatement();
	partial void Leave_withStatement();

	// $ANTLR start "withStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:159:1: withStatement : 'with' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement ;
	[GrammarRule("withStatement")]
	private JavaScriptParser.withStatement_return withStatement()
	{
		Enter_withStatement();
		EnterRule("withStatement", 31);
		TraceIn("withStatement", 31);
		JavaScriptParser.withStatement_return retval = new JavaScriptParser.withStatement_return();
		retval.Start = (IToken)input.LT(1);
		int withStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal172=null;
		IToken LT173=null;
		IToken char_literal174=null;
		IToken LT175=null;
		IToken LT177=null;
		IToken char_literal178=null;
		IToken LT179=null;
		JavaScriptParser.expression_return expression176 = default(JavaScriptParser.expression_return);
		JavaScriptParser.statement_return statement180 = default(JavaScriptParser.statement_return);

		object string_literal172_tree=null;
		object LT173_tree=null;
		object char_literal174_tree=null;
		object LT175_tree=null;
		object LT177_tree=null;
		object char_literal178_tree=null;
		object LT179_tree=null;

		try { DebugEnterRule(GrammarFileName, "withStatement");
		DebugLocation(159, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:160:2: ( 'with' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:160:4: 'with' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(160, 4);
			string_literal172=(IToken)Match(input,49,Follow._49_in_withStatement937); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal172_tree = (object)adaptor.Create(string_literal172);
			adaptor.AddChild(root_0, string_literal172_tree);
			}
			DebugLocation(160, 13);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:160:13: ( LT )*
			try { DebugEnterSubRule(79);
			while (true)
			{
				int alt79=2;
				try { DebugEnterDecision(79, decisionCanBacktrack[79]);
				int LA79_0 = input.LA(1);

				if ((LA79_0==LT))
				{
					alt79=1;
				}


				} finally { DebugExitDecision(79); }
				switch ( alt79 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(160, 13);
					LT173=(IToken)Match(input,LT,Follow._LT_in_withStatement939); if (state.failed) return retval;

					}
					break;

				default:
					goto loop79;
				}
			}

			loop79:
				;

			} finally { DebugExitSubRule(79); }

			DebugLocation(160, 16);
			char_literal174=(IToken)Match(input,32,Follow._32_in_withStatement943); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal174_tree = (object)adaptor.Create(char_literal174);
			adaptor.AddChild(root_0, char_literal174_tree);
			}
			DebugLocation(160, 22);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:160:22: ( LT )*
			try { DebugEnterSubRule(80);
			while (true)
			{
				int alt80=2;
				try { DebugEnterDecision(80, decisionCanBacktrack[80]);
				int LA80_0 = input.LA(1);

				if ((LA80_0==LT))
				{
					alt80=1;
				}


				} finally { DebugExitDecision(80); }
				switch ( alt80 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(160, 22);
					LT175=(IToken)Match(input,LT,Follow._LT_in_withStatement945); if (state.failed) return retval;

					}
					break;

				default:
					goto loop80;
				}
			}

			loop80:
				;

			} finally { DebugExitSubRule(80); }

			DebugLocation(160, 25);
			PushFollow(Follow._expression_in_withStatement949);
			expression176=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression176.Tree);
			DebugLocation(160, 38);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:160:38: ( LT )*
			try { DebugEnterSubRule(81);
			while (true)
			{
				int alt81=2;
				try { DebugEnterDecision(81, decisionCanBacktrack[81]);
				int LA81_0 = input.LA(1);

				if ((LA81_0==LT))
				{
					alt81=1;
				}


				} finally { DebugExitDecision(81); }
				switch ( alt81 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(160, 38);
					LT177=(IToken)Match(input,LT,Follow._LT_in_withStatement951); if (state.failed) return retval;

					}
					break;

				default:
					goto loop81;
				}
			}

			loop81:
				;

			} finally { DebugExitSubRule(81); }

			DebugLocation(160, 41);
			char_literal178=(IToken)Match(input,34,Follow._34_in_withStatement955); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal178_tree = (object)adaptor.Create(char_literal178);
			adaptor.AddChild(root_0, char_literal178_tree);
			}
			DebugLocation(160, 47);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:160:47: ( LT )*
			try { DebugEnterSubRule(82);
			while (true)
			{
				int alt82=2;
				try { DebugEnterDecision(82, decisionCanBacktrack[82]);
				int LA82_0 = input.LA(1);

				if ((LA82_0==LT))
				{
					alt82=1;
				}


				} finally { DebugExitDecision(82); }
				switch ( alt82 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(160, 47);
					LT179=(IToken)Match(input,LT,Follow._LT_in_withStatement957); if (state.failed) return retval;

					}
					break;

				default:
					goto loop82;
				}
			}

			loop82:
				;

			} finally { DebugExitSubRule(82); }

			DebugLocation(160, 50);
			PushFollow(Follow._statement_in_withStatement961);
			statement180=statement();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement180.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("withStatement", 31);
			LeaveRule("withStatement", 31);
			Leave_withStatement();
			if (state.backtracking > 0) { Memoize(input, 31, withStatement_StartIndex); }
		}
		DebugLocation(161, 1);
		} finally { DebugExitRule(GrammarFileName, "withStatement"); }
		return retval;

	}
	// $ANTLR end "withStatement"

	public class labelledStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_labelledStatement();
	partial void Leave_labelledStatement();

	// $ANTLR start "labelledStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:163:1: labelledStatement : Identifier ( LT )* ':' ( LT )* statement ;
	[GrammarRule("labelledStatement")]
	private JavaScriptParser.labelledStatement_return labelledStatement()
	{
		Enter_labelledStatement();
		EnterRule("labelledStatement", 32);
		TraceIn("labelledStatement", 32);
		JavaScriptParser.labelledStatement_return retval = new JavaScriptParser.labelledStatement_return();
		retval.Start = (IToken)input.LT(1);
		int labelledStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken Identifier181=null;
		IToken LT182=null;
		IToken char_literal183=null;
		IToken LT184=null;
		JavaScriptParser.statement_return statement185 = default(JavaScriptParser.statement_return);

		object Identifier181_tree=null;
		object LT182_tree=null;
		object char_literal183_tree=null;
		object LT184_tree=null;

		try { DebugEnterRule(GrammarFileName, "labelledStatement");
		DebugLocation(163, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:164:2: ( Identifier ( LT )* ':' ( LT )* statement )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:164:4: Identifier ( LT )* ':' ( LT )* statement
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(164, 4);
			Identifier181=(IToken)Match(input,Identifier,Follow._Identifier_in_labelledStatement972); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			Identifier181_tree = (object)adaptor.Create(Identifier181);
			adaptor.AddChild(root_0, Identifier181_tree);
			}
			DebugLocation(164, 17);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:164:17: ( LT )*
			try { DebugEnterSubRule(83);
			while (true)
			{
				int alt83=2;
				try { DebugEnterDecision(83, decisionCanBacktrack[83]);
				int LA83_0 = input.LA(1);

				if ((LA83_0==LT))
				{
					alt83=1;
				}


				} finally { DebugExitDecision(83); }
				switch ( alt83 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(164, 17);
					LT182=(IToken)Match(input,LT,Follow._LT_in_labelledStatement974); if (state.failed) return retval;

					}
					break;

				default:
					goto loop83;
				}
			}

			loop83:
				;

			} finally { DebugExitSubRule(83); }

			DebugLocation(164, 20);
			char_literal183=(IToken)Match(input,50,Follow._50_in_labelledStatement978); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal183_tree = (object)adaptor.Create(char_literal183);
			adaptor.AddChild(root_0, char_literal183_tree);
			}
			DebugLocation(164, 26);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:164:26: ( LT )*
			try { DebugEnterSubRule(84);
			while (true)
			{
				int alt84=2;
				try { DebugEnterDecision(84, decisionCanBacktrack[84]);
				int LA84_0 = input.LA(1);

				if ((LA84_0==LT))
				{
					alt84=1;
				}


				} finally { DebugExitDecision(84); }
				switch ( alt84 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(164, 26);
					LT184=(IToken)Match(input,LT,Follow._LT_in_labelledStatement980); if (state.failed) return retval;

					}
					break;

				default:
					goto loop84;
				}
			}

			loop84:
				;

			} finally { DebugExitSubRule(84); }

			DebugLocation(164, 29);
			PushFollow(Follow._statement_in_labelledStatement984);
			statement185=statement();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement185.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("labelledStatement", 32);
			LeaveRule("labelledStatement", 32);
			Leave_labelledStatement();
			if (state.backtracking > 0) { Memoize(input, 32, labelledStatement_StartIndex); }
		}
		DebugLocation(165, 1);
		} finally { DebugExitRule(GrammarFileName, "labelledStatement"); }
		return retval;

	}
	// $ANTLR end "labelledStatement"

	public class switchStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_switchStatement();
	partial void Leave_switchStatement();

	// $ANTLR start "switchStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:167:1: switchStatement : 'switch' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* caseBlock ;
	[GrammarRule("switchStatement")]
	private JavaScriptParser.switchStatement_return switchStatement()
	{
		Enter_switchStatement();
		EnterRule("switchStatement", 33);
		TraceIn("switchStatement", 33);
		JavaScriptParser.switchStatement_return retval = new JavaScriptParser.switchStatement_return();
		retval.Start = (IToken)input.LT(1);
		int switchStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal186=null;
		IToken LT187=null;
		IToken char_literal188=null;
		IToken LT189=null;
		IToken LT191=null;
		IToken char_literal192=null;
		IToken LT193=null;
		JavaScriptParser.expression_return expression190 = default(JavaScriptParser.expression_return);
		JavaScriptParser.caseBlock_return caseBlock194 = default(JavaScriptParser.caseBlock_return);

		object string_literal186_tree=null;
		object LT187_tree=null;
		object char_literal188_tree=null;
		object LT189_tree=null;
		object LT191_tree=null;
		object char_literal192_tree=null;
		object LT193_tree=null;

		try { DebugEnterRule(GrammarFileName, "switchStatement");
		DebugLocation(167, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:168:2: ( 'switch' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* caseBlock )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:168:4: 'switch' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* caseBlock
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(168, 4);
			string_literal186=(IToken)Match(input,51,Follow._51_in_switchStatement996); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal186_tree = (object)adaptor.Create(string_literal186);
			adaptor.AddChild(root_0, string_literal186_tree);
			}
			DebugLocation(168, 15);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:168:15: ( LT )*
			try { DebugEnterSubRule(85);
			while (true)
			{
				int alt85=2;
				try { DebugEnterDecision(85, decisionCanBacktrack[85]);
				int LA85_0 = input.LA(1);

				if ((LA85_0==LT))
				{
					alt85=1;
				}


				} finally { DebugExitDecision(85); }
				switch ( alt85 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(168, 15);
					LT187=(IToken)Match(input,LT,Follow._LT_in_switchStatement998); if (state.failed) return retval;

					}
					break;

				default:
					goto loop85;
				}
			}

			loop85:
				;

			} finally { DebugExitSubRule(85); }

			DebugLocation(168, 18);
			char_literal188=(IToken)Match(input,32,Follow._32_in_switchStatement1002); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal188_tree = (object)adaptor.Create(char_literal188);
			adaptor.AddChild(root_0, char_literal188_tree);
			}
			DebugLocation(168, 24);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:168:24: ( LT )*
			try { DebugEnterSubRule(86);
			while (true)
			{
				int alt86=2;
				try { DebugEnterDecision(86, decisionCanBacktrack[86]);
				int LA86_0 = input.LA(1);

				if ((LA86_0==LT))
				{
					alt86=1;
				}


				} finally { DebugExitDecision(86); }
				switch ( alt86 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(168, 24);
					LT189=(IToken)Match(input,LT,Follow._LT_in_switchStatement1004); if (state.failed) return retval;

					}
					break;

				default:
					goto loop86;
				}
			}

			loop86:
				;

			} finally { DebugExitSubRule(86); }

			DebugLocation(168, 27);
			PushFollow(Follow._expression_in_switchStatement1008);
			expression190=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression190.Tree);
			DebugLocation(168, 40);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:168:40: ( LT )*
			try { DebugEnterSubRule(87);
			while (true)
			{
				int alt87=2;
				try { DebugEnterDecision(87, decisionCanBacktrack[87]);
				int LA87_0 = input.LA(1);

				if ((LA87_0==LT))
				{
					alt87=1;
				}


				} finally { DebugExitDecision(87); }
				switch ( alt87 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(168, 40);
					LT191=(IToken)Match(input,LT,Follow._LT_in_switchStatement1010); if (state.failed) return retval;

					}
					break;

				default:
					goto loop87;
				}
			}

			loop87:
				;

			} finally { DebugExitSubRule(87); }

			DebugLocation(168, 43);
			char_literal192=(IToken)Match(input,34,Follow._34_in_switchStatement1014); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal192_tree = (object)adaptor.Create(char_literal192);
			adaptor.AddChild(root_0, char_literal192_tree);
			}
			DebugLocation(168, 49);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:168:49: ( LT )*
			try { DebugEnterSubRule(88);
			while (true)
			{
				int alt88=2;
				try { DebugEnterDecision(88, decisionCanBacktrack[88]);
				int LA88_0 = input.LA(1);

				if ((LA88_0==LT))
				{
					alt88=1;
				}


				} finally { DebugExitDecision(88); }
				switch ( alt88 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(168, 49);
					LT193=(IToken)Match(input,LT,Follow._LT_in_switchStatement1016); if (state.failed) return retval;

					}
					break;

				default:
					goto loop88;
				}
			}

			loop88:
				;

			} finally { DebugExitSubRule(88); }

			DebugLocation(168, 52);
			PushFollow(Follow._caseBlock_in_switchStatement1020);
			caseBlock194=caseBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, caseBlock194.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("switchStatement", 33);
			LeaveRule("switchStatement", 33);
			Leave_switchStatement();
			if (state.backtracking > 0) { Memoize(input, 33, switchStatement_StartIndex); }
		}
		DebugLocation(169, 1);
		} finally { DebugExitRule(GrammarFileName, "switchStatement"); }
		return retval;

	}
	// $ANTLR end "switchStatement"

	public class caseBlock_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_caseBlock();
	partial void Leave_caseBlock();

	// $ANTLR start "caseBlock"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:171:1: caseBlock : '{' ( ( LT )* caseClause )* ( ( LT )* defaultClause ( ( LT )* caseClause )* )? ( LT )* '}' ;
	[GrammarRule("caseBlock")]
	private JavaScriptParser.caseBlock_return caseBlock()
	{
		Enter_caseBlock();
		EnterRule("caseBlock", 34);
		TraceIn("caseBlock", 34);
		JavaScriptParser.caseBlock_return retval = new JavaScriptParser.caseBlock_return();
		retval.Start = (IToken)input.LT(1);
		int caseBlock_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal195=null;
		IToken LT196=null;
		IToken LT198=null;
		IToken LT200=null;
		IToken LT202=null;
		IToken char_literal203=null;
		JavaScriptParser.caseClause_return caseClause197 = default(JavaScriptParser.caseClause_return);
		JavaScriptParser.defaultClause_return defaultClause199 = default(JavaScriptParser.defaultClause_return);
		JavaScriptParser.caseClause_return caseClause201 = default(JavaScriptParser.caseClause_return);

		object char_literal195_tree=null;
		object LT196_tree=null;
		object LT198_tree=null;
		object LT200_tree=null;
		object LT202_tree=null;
		object char_literal203_tree=null;

		try { DebugEnterRule(GrammarFileName, "caseBlock");
		DebugLocation(171, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:172:2: ( '{' ( ( LT )* caseClause )* ( ( LT )* defaultClause ( ( LT )* caseClause )* )? ( LT )* '}' )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:172:4: '{' ( ( LT )* caseClause )* ( ( LT )* defaultClause ( ( LT )* caseClause )* )? ( LT )* '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(172, 4);
			char_literal195=(IToken)Match(input,35,Follow._35_in_caseBlock1032); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal195_tree = (object)adaptor.Create(char_literal195);
			adaptor.AddChild(root_0, char_literal195_tree);
			}
			DebugLocation(172, 8);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:172:8: ( ( LT )* caseClause )*
			try { DebugEnterSubRule(90);
			while (true)
			{
				int alt90=2;
				try { DebugEnterDecision(90, decisionCanBacktrack[90]);
				try
				{
					alt90 = dfa90.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(90); }
				switch ( alt90 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:172:9: ( LT )* caseClause
					{
					DebugLocation(172, 11);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:172:11: ( LT )*
					try { DebugEnterSubRule(89);
					while (true)
					{
						int alt89=2;
						try { DebugEnterDecision(89, decisionCanBacktrack[89]);
						int LA89_0 = input.LA(1);

						if ((LA89_0==LT))
						{
							alt89=1;
						}


						} finally { DebugExitDecision(89); }
						switch ( alt89 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(172, 11);
							LT196=(IToken)Match(input,LT,Follow._LT_in_caseBlock1035); if (state.failed) return retval;

							}
							break;

						default:
							goto loop89;
						}
					}

					loop89:
						;

					} finally { DebugExitSubRule(89); }

					DebugLocation(172, 14);
					PushFollow(Follow._caseClause_in_caseBlock1039);
					caseClause197=caseClause();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, caseClause197.Tree);

					}
					break;

				default:
					goto loop90;
				}
			}

			loop90:
				;

			} finally { DebugExitSubRule(90); }

			DebugLocation(172, 27);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:172:27: ( ( LT )* defaultClause ( ( LT )* caseClause )* )?
			int alt94=2;
			try { DebugEnterSubRule(94);
			try { DebugEnterDecision(94, decisionCanBacktrack[94]);
			try
			{
				alt94 = dfa94.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(94); }
			switch (alt94)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:172:28: ( LT )* defaultClause ( ( LT )* caseClause )*
				{
				DebugLocation(172, 30);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:172:30: ( LT )*
				try { DebugEnterSubRule(91);
				while (true)
				{
					int alt91=2;
					try { DebugEnterDecision(91, decisionCanBacktrack[91]);
					int LA91_0 = input.LA(1);

					if ((LA91_0==LT))
					{
						alt91=1;
					}


					} finally { DebugExitDecision(91); }
					switch ( alt91 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(172, 30);
						LT198=(IToken)Match(input,LT,Follow._LT_in_caseBlock1044); if (state.failed) return retval;

						}
						break;

					default:
						goto loop91;
					}
				}

				loop91:
					;

				} finally { DebugExitSubRule(91); }

				DebugLocation(172, 33);
				PushFollow(Follow._defaultClause_in_caseBlock1048);
				defaultClause199=defaultClause();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defaultClause199.Tree);
				DebugLocation(172, 47);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:172:47: ( ( LT )* caseClause )*
				try { DebugEnterSubRule(93);
				while (true)
				{
					int alt93=2;
					try { DebugEnterDecision(93, decisionCanBacktrack[93]);
					try
					{
						alt93 = dfa93.Predict(input);
					}
					catch (NoViableAltException nvae)
					{
						DebugRecognitionException(nvae);
						throw;
					}
					} finally { DebugExitDecision(93); }
					switch ( alt93 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:172:48: ( LT )* caseClause
						{
						DebugLocation(172, 50);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:172:50: ( LT )*
						try { DebugEnterSubRule(92);
						while (true)
						{
							int alt92=2;
							try { DebugEnterDecision(92, decisionCanBacktrack[92]);
							int LA92_0 = input.LA(1);

							if ((LA92_0==LT))
							{
								alt92=1;
							}


							} finally { DebugExitDecision(92); }
							switch ( alt92 )
							{
							case 1:
								DebugEnterAlt(1);
								// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
								{
								DebugLocation(172, 50);
								LT200=(IToken)Match(input,LT,Follow._LT_in_caseBlock1051); if (state.failed) return retval;

								}
								break;

							default:
								goto loop92;
							}
						}

						loop92:
							;

						} finally { DebugExitSubRule(92); }

						DebugLocation(172, 53);
						PushFollow(Follow._caseClause_in_caseBlock1055);
						caseClause201=caseClause();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, caseClause201.Tree);

						}
						break;

					default:
						goto loop93;
					}
				}

				loop93:
					;

				} finally { DebugExitSubRule(93); }


				}
				break;

			}
			} finally { DebugExitSubRule(94); }

			DebugLocation(172, 70);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:172:70: ( LT )*
			try { DebugEnterSubRule(95);
			while (true)
			{
				int alt95=2;
				try { DebugEnterDecision(95, decisionCanBacktrack[95]);
				int LA95_0 = input.LA(1);

				if ((LA95_0==LT))
				{
					alt95=1;
				}


				} finally { DebugExitDecision(95); }
				switch ( alt95 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(172, 70);
					LT202=(IToken)Match(input,LT,Follow._LT_in_caseBlock1061); if (state.failed) return retval;

					}
					break;

				default:
					goto loop95;
				}
			}

			loop95:
				;

			} finally { DebugExitSubRule(95); }

			DebugLocation(172, 73);
			char_literal203=(IToken)Match(input,36,Follow._36_in_caseBlock1065); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal203_tree = (object)adaptor.Create(char_literal203);
			adaptor.AddChild(root_0, char_literal203_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("caseBlock", 34);
			LeaveRule("caseBlock", 34);
			Leave_caseBlock();
			if (state.backtracking > 0) { Memoize(input, 34, caseBlock_StartIndex); }
		}
		DebugLocation(173, 1);
		} finally { DebugExitRule(GrammarFileName, "caseBlock"); }
		return retval;

	}
	// $ANTLR end "caseBlock"

	public class caseClause_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_caseClause();
	partial void Leave_caseClause();

	// $ANTLR start "caseClause"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:175:1: caseClause : 'case' ( LT )* expression ( LT )* ':' ( LT )* ( statementList )? ;
	[GrammarRule("caseClause")]
	private JavaScriptParser.caseClause_return caseClause()
	{
		Enter_caseClause();
		EnterRule("caseClause", 35);
		TraceIn("caseClause", 35);
		JavaScriptParser.caseClause_return retval = new JavaScriptParser.caseClause_return();
		retval.Start = (IToken)input.LT(1);
		int caseClause_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal204=null;
		IToken LT205=null;
		IToken LT207=null;
		IToken char_literal208=null;
		IToken LT209=null;
		JavaScriptParser.expression_return expression206 = default(JavaScriptParser.expression_return);
		JavaScriptParser.statementList_return statementList210 = default(JavaScriptParser.statementList_return);

		object string_literal204_tree=null;
		object LT205_tree=null;
		object LT207_tree=null;
		object char_literal208_tree=null;
		object LT209_tree=null;

		try { DebugEnterRule(GrammarFileName, "caseClause");
		DebugLocation(175, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 35)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:176:2: ( 'case' ( LT )* expression ( LT )* ':' ( LT )* ( statementList )? )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:176:4: 'case' ( LT )* expression ( LT )* ':' ( LT )* ( statementList )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(176, 4);
			string_literal204=(IToken)Match(input,52,Follow._52_in_caseClause1076); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal204_tree = (object)adaptor.Create(string_literal204);
			adaptor.AddChild(root_0, string_literal204_tree);
			}
			DebugLocation(176, 13);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:176:13: ( LT )*
			try { DebugEnterSubRule(96);
			while (true)
			{
				int alt96=2;
				try { DebugEnterDecision(96, decisionCanBacktrack[96]);
				int LA96_0 = input.LA(1);

				if ((LA96_0==LT))
				{
					alt96=1;
				}


				} finally { DebugExitDecision(96); }
				switch ( alt96 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(176, 13);
					LT205=(IToken)Match(input,LT,Follow._LT_in_caseClause1078); if (state.failed) return retval;

					}
					break;

				default:
					goto loop96;
				}
			}

			loop96:
				;

			} finally { DebugExitSubRule(96); }

			DebugLocation(176, 16);
			PushFollow(Follow._expression_in_caseClause1082);
			expression206=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression206.Tree);
			DebugLocation(176, 29);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:176:29: ( LT )*
			try { DebugEnterSubRule(97);
			while (true)
			{
				int alt97=2;
				try { DebugEnterDecision(97, decisionCanBacktrack[97]);
				int LA97_0 = input.LA(1);

				if ((LA97_0==LT))
				{
					alt97=1;
				}


				} finally { DebugExitDecision(97); }
				switch ( alt97 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(176, 29);
					LT207=(IToken)Match(input,LT,Follow._LT_in_caseClause1084); if (state.failed) return retval;

					}
					break;

				default:
					goto loop97;
				}
			}

			loop97:
				;

			} finally { DebugExitSubRule(97); }

			DebugLocation(176, 32);
			char_literal208=(IToken)Match(input,50,Follow._50_in_caseClause1088); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal208_tree = (object)adaptor.Create(char_literal208);
			adaptor.AddChild(root_0, char_literal208_tree);
			}
			DebugLocation(176, 38);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:176:38: ( LT )*
			try { DebugEnterSubRule(98);
			while (true)
			{
				int alt98=2;
				try { DebugEnterDecision(98, decisionCanBacktrack[98]);
				int LA98_0 = input.LA(1);

				if ((LA98_0==LT))
				{
					int LA98_2 = input.LA(2);

					if ((EvaluatePredicate(synpred118_JavaScript_fragment)))
					{
						alt98=1;
					}


				}


				} finally { DebugExitDecision(98); }
				switch ( alt98 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(176, 38);
					LT209=(IToken)Match(input,LT,Follow._LT_in_caseClause1090); if (state.failed) return retval;

					}
					break;

				default:
					goto loop98;
				}
			}

			loop98:
				;

			} finally { DebugExitSubRule(98); }

			DebugLocation(176, 41);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:176:41: ( statementList )?
			int alt99=2;
			try { DebugEnterSubRule(99);
			try { DebugEnterDecision(99, decisionCanBacktrack[99]);
			int LA99_0 = input.LA(1);

			if (((LA99_0>=Identifier && LA99_0<=NumericLiteral)||(LA99_0>=31 && LA99_0<=32)||LA99_0==35||(LA99_0>=37 && LA99_0<=38)||LA99_0==40||(LA99_0>=42 && LA99_0<=44)||(LA99_0>=46 && LA99_0<=49)||LA99_0==51||(LA99_0>=54 && LA99_0<=55)||(LA99_0>=58 && LA99_0<=59)||(LA99_0>=91 && LA99_0<=92)||(LA99_0>=96 && LA99_0<=106)))
			{
				alt99=1;
			}
			} finally { DebugExitDecision(99); }
			switch (alt99)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: statementList
				{
				DebugLocation(176, 41);
				PushFollow(Follow._statementList_in_caseClause1094);
				statementList210=statementList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementList210.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(99); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("caseClause", 35);
			LeaveRule("caseClause", 35);
			Leave_caseClause();
			if (state.backtracking > 0) { Memoize(input, 35, caseClause_StartIndex); }
		}
		DebugLocation(177, 1);
		} finally { DebugExitRule(GrammarFileName, "caseClause"); }
		return retval;

	}
	// $ANTLR end "caseClause"

	public class defaultClause_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_defaultClause();
	partial void Leave_defaultClause();

	// $ANTLR start "defaultClause"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:179:1: defaultClause : 'default' ( LT )* ':' ( LT )* ( statementList )? ;
	[GrammarRule("defaultClause")]
	private JavaScriptParser.defaultClause_return defaultClause()
	{
		Enter_defaultClause();
		EnterRule("defaultClause", 36);
		TraceIn("defaultClause", 36);
		JavaScriptParser.defaultClause_return retval = new JavaScriptParser.defaultClause_return();
		retval.Start = (IToken)input.LT(1);
		int defaultClause_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal211=null;
		IToken LT212=null;
		IToken char_literal213=null;
		IToken LT214=null;
		JavaScriptParser.statementList_return statementList215 = default(JavaScriptParser.statementList_return);

		object string_literal211_tree=null;
		object LT212_tree=null;
		object char_literal213_tree=null;
		object LT214_tree=null;

		try { DebugEnterRule(GrammarFileName, "defaultClause");
		DebugLocation(179, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 36)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:180:2: ( 'default' ( LT )* ':' ( LT )* ( statementList )? )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:180:4: 'default' ( LT )* ':' ( LT )* ( statementList )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(180, 4);
			string_literal211=(IToken)Match(input,53,Follow._53_in_defaultClause1107); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal211_tree = (object)adaptor.Create(string_literal211);
			adaptor.AddChild(root_0, string_literal211_tree);
			}
			DebugLocation(180, 16);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:180:16: ( LT )*
			try { DebugEnterSubRule(100);
			while (true)
			{
				int alt100=2;
				try { DebugEnterDecision(100, decisionCanBacktrack[100]);
				int LA100_0 = input.LA(1);

				if ((LA100_0==LT))
				{
					alt100=1;
				}


				} finally { DebugExitDecision(100); }
				switch ( alt100 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(180, 16);
					LT212=(IToken)Match(input,LT,Follow._LT_in_defaultClause1109); if (state.failed) return retval;

					}
					break;

				default:
					goto loop100;
				}
			}

			loop100:
				;

			} finally { DebugExitSubRule(100); }

			DebugLocation(180, 19);
			char_literal213=(IToken)Match(input,50,Follow._50_in_defaultClause1113); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal213_tree = (object)adaptor.Create(char_literal213);
			adaptor.AddChild(root_0, char_literal213_tree);
			}
			DebugLocation(180, 25);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:180:25: ( LT )*
			try { DebugEnterSubRule(101);
			while (true)
			{
				int alt101=2;
				try { DebugEnterDecision(101, decisionCanBacktrack[101]);
				int LA101_0 = input.LA(1);

				if ((LA101_0==LT))
				{
					int LA101_2 = input.LA(2);

					if ((EvaluatePredicate(synpred121_JavaScript_fragment)))
					{
						alt101=1;
					}


				}


				} finally { DebugExitDecision(101); }
				switch ( alt101 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(180, 25);
					LT214=(IToken)Match(input,LT,Follow._LT_in_defaultClause1115); if (state.failed) return retval;

					}
					break;

				default:
					goto loop101;
				}
			}

			loop101:
				;

			} finally { DebugExitSubRule(101); }

			DebugLocation(180, 28);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:180:28: ( statementList )?
			int alt102=2;
			try { DebugEnterSubRule(102);
			try { DebugEnterDecision(102, decisionCanBacktrack[102]);
			int LA102_0 = input.LA(1);

			if (((LA102_0>=Identifier && LA102_0<=NumericLiteral)||(LA102_0>=31 && LA102_0<=32)||LA102_0==35||(LA102_0>=37 && LA102_0<=38)||LA102_0==40||(LA102_0>=42 && LA102_0<=44)||(LA102_0>=46 && LA102_0<=49)||LA102_0==51||(LA102_0>=54 && LA102_0<=55)||(LA102_0>=58 && LA102_0<=59)||(LA102_0>=91 && LA102_0<=92)||(LA102_0>=96 && LA102_0<=106)))
			{
				alt102=1;
			}
			} finally { DebugExitDecision(102); }
			switch (alt102)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: statementList
				{
				DebugLocation(180, 28);
				PushFollow(Follow._statementList_in_defaultClause1119);
				statementList215=statementList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementList215.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(102); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("defaultClause", 36);
			LeaveRule("defaultClause", 36);
			Leave_defaultClause();
			if (state.backtracking > 0) { Memoize(input, 36, defaultClause_StartIndex); }
		}
		DebugLocation(181, 1);
		} finally { DebugExitRule(GrammarFileName, "defaultClause"); }
		return retval;

	}
	// $ANTLR end "defaultClause"

	public class throwStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_throwStatement();
	partial void Leave_throwStatement();

	// $ANTLR start "throwStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:183:1: throwStatement : 'throw' expression ( LT | ';' ) ;
	[GrammarRule("throwStatement")]
	private JavaScriptParser.throwStatement_return throwStatement()
	{
		Enter_throwStatement();
		EnterRule("throwStatement", 37);
		TraceIn("throwStatement", 37);
		JavaScriptParser.throwStatement_return retval = new JavaScriptParser.throwStatement_return();
		retval.Start = (IToken)input.LT(1);
		int throwStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal216=null;
		IToken set218=null;
		JavaScriptParser.expression_return expression217 = default(JavaScriptParser.expression_return);

		object string_literal216_tree=null;
		object set218_tree=null;

		try { DebugEnterRule(GrammarFileName, "throwStatement");
		DebugLocation(183, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 37)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:184:2: ( 'throw' expression ( LT | ';' ) )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:184:4: 'throw' expression ( LT | ';' )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(184, 4);
			string_literal216=(IToken)Match(input,54,Follow._54_in_throwStatement1132); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal216_tree = (object)adaptor.Create(string_literal216);
			adaptor.AddChild(root_0, string_literal216_tree);
			}
			DebugLocation(184, 12);
			PushFollow(Follow._expression_in_throwStatement1134);
			expression217=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression217.Tree);
			DebugLocation(184, 23);
			set218=(IToken)input.LT(1);
			if (input.LA(1)==LT||input.LA(1)==38)
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("throwStatement", 37);
			LeaveRule("throwStatement", 37);
			Leave_throwStatement();
			if (state.backtracking > 0) { Memoize(input, 37, throwStatement_StartIndex); }
		}
		DebugLocation(185, 1);
		} finally { DebugExitRule(GrammarFileName, "throwStatement"); }
		return retval;

	}
	// $ANTLR end "throwStatement"

	public class tryStatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_tryStatement();
	partial void Leave_tryStatement();

	// $ANTLR start "tryStatement"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:187:1: tryStatement : 'try' ( LT )* statementBlock ( LT )* ( finallyClause | catchClause ( ( LT )* finallyClause )? ) ;
	[GrammarRule("tryStatement")]
	private JavaScriptParser.tryStatement_return tryStatement()
	{
		Enter_tryStatement();
		EnterRule("tryStatement", 38);
		TraceIn("tryStatement", 38);
		JavaScriptParser.tryStatement_return retval = new JavaScriptParser.tryStatement_return();
		retval.Start = (IToken)input.LT(1);
		int tryStatement_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal219=null;
		IToken LT220=null;
		IToken LT222=null;
		IToken LT225=null;
		JavaScriptParser.statementBlock_return statementBlock221 = default(JavaScriptParser.statementBlock_return);
		JavaScriptParser.finallyClause_return finallyClause223 = default(JavaScriptParser.finallyClause_return);
		JavaScriptParser.catchClause_return catchClause224 = default(JavaScriptParser.catchClause_return);
		JavaScriptParser.finallyClause_return finallyClause226 = default(JavaScriptParser.finallyClause_return);

		object string_literal219_tree=null;
		object LT220_tree=null;
		object LT222_tree=null;
		object LT225_tree=null;

		try { DebugEnterRule(GrammarFileName, "tryStatement");
		DebugLocation(187, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 38)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:188:2: ( 'try' ( LT )* statementBlock ( LT )* ( finallyClause | catchClause ( ( LT )* finallyClause )? ) )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:188:4: 'try' ( LT )* statementBlock ( LT )* ( finallyClause | catchClause ( ( LT )* finallyClause )? )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(188, 4);
			string_literal219=(IToken)Match(input,55,Follow._55_in_tryStatement1154); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal219_tree = (object)adaptor.Create(string_literal219);
			adaptor.AddChild(root_0, string_literal219_tree);
			}
			DebugLocation(188, 12);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:188:12: ( LT )*
			try { DebugEnterSubRule(103);
			while (true)
			{
				int alt103=2;
				try { DebugEnterDecision(103, decisionCanBacktrack[103]);
				int LA103_0 = input.LA(1);

				if ((LA103_0==LT))
				{
					alt103=1;
				}


				} finally { DebugExitDecision(103); }
				switch ( alt103 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(188, 12);
					LT220=(IToken)Match(input,LT,Follow._LT_in_tryStatement1156); if (state.failed) return retval;

					}
					break;

				default:
					goto loop103;
				}
			}

			loop103:
				;

			} finally { DebugExitSubRule(103); }

			DebugLocation(188, 15);
			PushFollow(Follow._statementBlock_in_tryStatement1160);
			statementBlock221=statementBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementBlock221.Tree);
			DebugLocation(188, 32);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:188:32: ( LT )*
			try { DebugEnterSubRule(104);
			while (true)
			{
				int alt104=2;
				try { DebugEnterDecision(104, decisionCanBacktrack[104]);
				int LA104_0 = input.LA(1);

				if ((LA104_0==LT))
				{
					alt104=1;
				}


				} finally { DebugExitDecision(104); }
				switch ( alt104 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(188, 32);
					LT222=(IToken)Match(input,LT,Follow._LT_in_tryStatement1162); if (state.failed) return retval;

					}
					break;

				default:
					goto loop104;
				}
			}

			loop104:
				;

			} finally { DebugExitSubRule(104); }

			DebugLocation(188, 35);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:188:35: ( finallyClause | catchClause ( ( LT )* finallyClause )? )
			int alt107=2;
			try { DebugEnterSubRule(107);
			try { DebugEnterDecision(107, decisionCanBacktrack[107]);
			int LA107_0 = input.LA(1);

			if ((LA107_0==57))
			{
				alt107=1;
			}
			else if ((LA107_0==56))
			{
				alt107=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 107, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(107); }
			switch (alt107)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:188:36: finallyClause
				{
				DebugLocation(188, 36);
				PushFollow(Follow._finallyClause_in_tryStatement1167);
				finallyClause223=finallyClause();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, finallyClause223.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:188:52: catchClause ( ( LT )* finallyClause )?
				{
				DebugLocation(188, 52);
				PushFollow(Follow._catchClause_in_tryStatement1171);
				catchClause224=catchClause();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, catchClause224.Tree);
				DebugLocation(188, 64);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:188:64: ( ( LT )* finallyClause )?
				int alt106=2;
				try { DebugEnterSubRule(106);
				try { DebugEnterDecision(106, decisionCanBacktrack[106]);
				try
				{
					alt106 = dfa106.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(106); }
				switch (alt106)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:188:65: ( LT )* finallyClause
					{
					DebugLocation(188, 67);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:188:67: ( LT )*
					try { DebugEnterSubRule(105);
					while (true)
					{
						int alt105=2;
						try { DebugEnterDecision(105, decisionCanBacktrack[105]);
						int LA105_0 = input.LA(1);

						if ((LA105_0==LT))
						{
							alt105=1;
						}


						} finally { DebugExitDecision(105); }
						switch ( alt105 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(188, 67);
							LT225=(IToken)Match(input,LT,Follow._LT_in_tryStatement1174); if (state.failed) return retval;

							}
							break;

						default:
							goto loop105;
						}
					}

					loop105:
						;

					} finally { DebugExitSubRule(105); }

					DebugLocation(188, 70);
					PushFollow(Follow._finallyClause_in_tryStatement1178);
					finallyClause226=finallyClause();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, finallyClause226.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(106); }


				}
				break;

			}
			} finally { DebugExitSubRule(107); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("tryStatement", 38);
			LeaveRule("tryStatement", 38);
			Leave_tryStatement();
			if (state.backtracking > 0) { Memoize(input, 38, tryStatement_StartIndex); }
		}
		DebugLocation(189, 1);
		} finally { DebugExitRule(GrammarFileName, "tryStatement"); }
		return retval;

	}
	// $ANTLR end "tryStatement"

	public class catchClause_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_catchClause();
	partial void Leave_catchClause();

	// $ANTLR start "catchClause"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:191:1: catchClause : 'catch' ( LT )* '(' ( LT )* Identifier ( LT )* ')' ( LT )* statementBlock ;
	[GrammarRule("catchClause")]
	private JavaScriptParser.catchClause_return catchClause()
	{
		Enter_catchClause();
		EnterRule("catchClause", 39);
		TraceIn("catchClause", 39);
		JavaScriptParser.catchClause_return retval = new JavaScriptParser.catchClause_return();
		retval.Start = (IToken)input.LT(1);
		int catchClause_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal227=null;
		IToken LT228=null;
		IToken char_literal229=null;
		IToken LT230=null;
		IToken Identifier231=null;
		IToken LT232=null;
		IToken char_literal233=null;
		IToken LT234=null;
		JavaScriptParser.statementBlock_return statementBlock235 = default(JavaScriptParser.statementBlock_return);

		object string_literal227_tree=null;
		object LT228_tree=null;
		object char_literal229_tree=null;
		object LT230_tree=null;
		object Identifier231_tree=null;
		object LT232_tree=null;
		object char_literal233_tree=null;
		object LT234_tree=null;

		try { DebugEnterRule(GrammarFileName, "catchClause");
		DebugLocation(191, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 39)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:192:2: ( 'catch' ( LT )* '(' ( LT )* Identifier ( LT )* ')' ( LT )* statementBlock )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:192:4: 'catch' ( LT )* '(' ( LT )* Identifier ( LT )* ')' ( LT )* statementBlock
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(192, 4);
			string_literal227=(IToken)Match(input,56,Follow._56_in_catchClause1199); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal227_tree = (object)adaptor.Create(string_literal227);
			adaptor.AddChild(root_0, string_literal227_tree);
			}
			DebugLocation(192, 14);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:192:14: ( LT )*
			try { DebugEnterSubRule(108);
			while (true)
			{
				int alt108=2;
				try { DebugEnterDecision(108, decisionCanBacktrack[108]);
				int LA108_0 = input.LA(1);

				if ((LA108_0==LT))
				{
					alt108=1;
				}


				} finally { DebugExitDecision(108); }
				switch ( alt108 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(192, 14);
					LT228=(IToken)Match(input,LT,Follow._LT_in_catchClause1201); if (state.failed) return retval;

					}
					break;

				default:
					goto loop108;
				}
			}

			loop108:
				;

			} finally { DebugExitSubRule(108); }

			DebugLocation(192, 17);
			char_literal229=(IToken)Match(input,32,Follow._32_in_catchClause1205); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal229_tree = (object)adaptor.Create(char_literal229);
			adaptor.AddChild(root_0, char_literal229_tree);
			}
			DebugLocation(192, 23);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:192:23: ( LT )*
			try { DebugEnterSubRule(109);
			while (true)
			{
				int alt109=2;
				try { DebugEnterDecision(109, decisionCanBacktrack[109]);
				int LA109_0 = input.LA(1);

				if ((LA109_0==LT))
				{
					alt109=1;
				}


				} finally { DebugExitDecision(109); }
				switch ( alt109 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(192, 23);
					LT230=(IToken)Match(input,LT,Follow._LT_in_catchClause1207); if (state.failed) return retval;

					}
					break;

				default:
					goto loop109;
				}
			}

			loop109:
				;

			} finally { DebugExitSubRule(109); }

			DebugLocation(192, 26);
			Identifier231=(IToken)Match(input,Identifier,Follow._Identifier_in_catchClause1211); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			Identifier231_tree = (object)adaptor.Create(Identifier231);
			adaptor.AddChild(root_0, Identifier231_tree);
			}
			DebugLocation(192, 39);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:192:39: ( LT )*
			try { DebugEnterSubRule(110);
			while (true)
			{
				int alt110=2;
				try { DebugEnterDecision(110, decisionCanBacktrack[110]);
				int LA110_0 = input.LA(1);

				if ((LA110_0==LT))
				{
					alt110=1;
				}


				} finally { DebugExitDecision(110); }
				switch ( alt110 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(192, 39);
					LT232=(IToken)Match(input,LT,Follow._LT_in_catchClause1213); if (state.failed) return retval;

					}
					break;

				default:
					goto loop110;
				}
			}

			loop110:
				;

			} finally { DebugExitSubRule(110); }

			DebugLocation(192, 42);
			char_literal233=(IToken)Match(input,34,Follow._34_in_catchClause1217); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal233_tree = (object)adaptor.Create(char_literal233);
			adaptor.AddChild(root_0, char_literal233_tree);
			}
			DebugLocation(192, 48);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:192:48: ( LT )*
			try { DebugEnterSubRule(111);
			while (true)
			{
				int alt111=2;
				try { DebugEnterDecision(111, decisionCanBacktrack[111]);
				int LA111_0 = input.LA(1);

				if ((LA111_0==LT))
				{
					alt111=1;
				}


				} finally { DebugExitDecision(111); }
				switch ( alt111 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(192, 48);
					LT234=(IToken)Match(input,LT,Follow._LT_in_catchClause1219); if (state.failed) return retval;

					}
					break;

				default:
					goto loop111;
				}
			}

			loop111:
				;

			} finally { DebugExitSubRule(111); }

			DebugLocation(192, 51);
			PushFollow(Follow._statementBlock_in_catchClause1223);
			statementBlock235=statementBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementBlock235.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("catchClause", 39);
			LeaveRule("catchClause", 39);
			Leave_catchClause();
			if (state.backtracking > 0) { Memoize(input, 39, catchClause_StartIndex); }
		}
		DebugLocation(193, 1);
		} finally { DebugExitRule(GrammarFileName, "catchClause"); }
		return retval;

	}
	// $ANTLR end "catchClause"

	public class finallyClause_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_finallyClause();
	partial void Leave_finallyClause();

	// $ANTLR start "finallyClause"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:195:1: finallyClause : 'finally' ( LT )* statementBlock ;
	[GrammarRule("finallyClause")]
	private JavaScriptParser.finallyClause_return finallyClause()
	{
		Enter_finallyClause();
		EnterRule("finallyClause", 40);
		TraceIn("finallyClause", 40);
		JavaScriptParser.finallyClause_return retval = new JavaScriptParser.finallyClause_return();
		retval.Start = (IToken)input.LT(1);
		int finallyClause_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal236=null;
		IToken LT237=null;
		JavaScriptParser.statementBlock_return statementBlock238 = default(JavaScriptParser.statementBlock_return);

		object string_literal236_tree=null;
		object LT237_tree=null;

		try { DebugEnterRule(GrammarFileName, "finallyClause");
		DebugLocation(195, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 40)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:196:2: ( 'finally' ( LT )* statementBlock )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:196:4: 'finally' ( LT )* statementBlock
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(196, 4);
			string_literal236=(IToken)Match(input,57,Follow._57_in_finallyClause1235); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			string_literal236_tree = (object)adaptor.Create(string_literal236);
			adaptor.AddChild(root_0, string_literal236_tree);
			}
			DebugLocation(196, 16);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:196:16: ( LT )*
			try { DebugEnterSubRule(112);
			while (true)
			{
				int alt112=2;
				try { DebugEnterDecision(112, decisionCanBacktrack[112]);
				int LA112_0 = input.LA(1);

				if ((LA112_0==LT))
				{
					alt112=1;
				}


				} finally { DebugExitDecision(112); }
				switch ( alt112 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(196, 16);
					LT237=(IToken)Match(input,LT,Follow._LT_in_finallyClause1237); if (state.failed) return retval;

					}
					break;

				default:
					goto loop112;
				}
			}

			loop112:
				;

			} finally { DebugExitSubRule(112); }

			DebugLocation(196, 19);
			PushFollow(Follow._statementBlock_in_finallyClause1241);
			statementBlock238=statementBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementBlock238.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("finallyClause", 40);
			LeaveRule("finallyClause", 40);
			Leave_finallyClause();
			if (state.backtracking > 0) { Memoize(input, 40, finallyClause_StartIndex); }
		}
		DebugLocation(197, 1);
		} finally { DebugExitRule(GrammarFileName, "finallyClause"); }
		return retval;

	}
	// $ANTLR end "finallyClause"

	public class expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expression();
	partial void Leave_expression();

	// $ANTLR start "expression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:200:1: expression : assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* ;
	[GrammarRule("expression")]
	private JavaScriptParser.expression_return expression()
	{
		Enter_expression();
		EnterRule("expression", 41);
		TraceIn("expression", 41);
		JavaScriptParser.expression_return retval = new JavaScriptParser.expression_return();
		retval.Start = (IToken)input.LT(1);
		int expression_StartIndex = input.Index;
		object root_0 = null;

		IToken LT240=null;
		IToken char_literal241=null;
		IToken LT242=null;
		JavaScriptParser.assignmentExpression_return assignmentExpression239 = default(JavaScriptParser.assignmentExpression_return);
		JavaScriptParser.assignmentExpression_return assignmentExpression243 = default(JavaScriptParser.assignmentExpression_return);

		object LT240_tree=null;
		object char_literal241_tree=null;
		object LT242_tree=null;

		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(200, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 41)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:201:2: ( assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:201:4: assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(201, 4);
			PushFollow(Follow._assignmentExpression_in_expression1253);
			assignmentExpression239=assignmentExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression239.Tree);
			DebugLocation(201, 25);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:201:25: ( ( LT )* ',' ( LT )* assignmentExpression )*
			try { DebugEnterSubRule(115);
			while (true)
			{
				int alt115=2;
				try { DebugEnterDecision(115, decisionCanBacktrack[115]);
				try
				{
					alt115 = dfa115.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(115); }
				switch ( alt115 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:201:26: ( LT )* ',' ( LT )* assignmentExpression
					{
					DebugLocation(201, 28);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:201:28: ( LT )*
					try { DebugEnterSubRule(113);
					while (true)
					{
						int alt113=2;
						try { DebugEnterDecision(113, decisionCanBacktrack[113]);
						int LA113_0 = input.LA(1);

						if ((LA113_0==LT))
						{
							alt113=1;
						}


						} finally { DebugExitDecision(113); }
						switch ( alt113 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(201, 28);
							LT240=(IToken)Match(input,LT,Follow._LT_in_expression1256); if (state.failed) return retval;

							}
							break;

						default:
							goto loop113;
						}
					}

					loop113:
						;

					} finally { DebugExitSubRule(113); }

					DebugLocation(201, 31);
					char_literal241=(IToken)Match(input,33,Follow._33_in_expression1260); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					char_literal241_tree = (object)adaptor.Create(char_literal241);
					adaptor.AddChild(root_0, char_literal241_tree);
					}
					DebugLocation(201, 37);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:201:37: ( LT )*
					try { DebugEnterSubRule(114);
					while (true)
					{
						int alt114=2;
						try { DebugEnterDecision(114, decisionCanBacktrack[114]);
						int LA114_0 = input.LA(1);

						if ((LA114_0==LT))
						{
							alt114=1;
						}


						} finally { DebugExitDecision(114); }
						switch ( alt114 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(201, 37);
							LT242=(IToken)Match(input,LT,Follow._LT_in_expression1262); if (state.failed) return retval;

							}
							break;

						default:
							goto loop114;
						}
					}

					loop114:
						;

					} finally { DebugExitSubRule(114); }

					DebugLocation(201, 40);
					PushFollow(Follow._assignmentExpression_in_expression1266);
					assignmentExpression243=assignmentExpression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression243.Tree);

					}
					break;

				default:
					goto loop115;
				}
			}

			loop115:
				;

			} finally { DebugExitSubRule(115); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expression", 41);
			LeaveRule("expression", 41);
			Leave_expression();
			if (state.backtracking > 0) { Memoize(input, 41, expression_StartIndex); }
		}
		DebugLocation(202, 1);
		} finally { DebugExitRule(GrammarFileName, "expression"); }
		return retval;

	}
	// $ANTLR end "expression"

	public class expressionNoIn_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expressionNoIn();
	partial void Leave_expressionNoIn();

	// $ANTLR start "expressionNoIn"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:204:1: expressionNoIn : assignmentExpressionNoIn ( ( LT )* ',' ( LT )* assignmentExpressionNoIn )* ;
	[GrammarRule("expressionNoIn")]
	private JavaScriptParser.expressionNoIn_return expressionNoIn()
	{
		Enter_expressionNoIn();
		EnterRule("expressionNoIn", 42);
		TraceIn("expressionNoIn", 42);
		JavaScriptParser.expressionNoIn_return retval = new JavaScriptParser.expressionNoIn_return();
		retval.Start = (IToken)input.LT(1);
		int expressionNoIn_StartIndex = input.Index;
		object root_0 = null;

		IToken LT245=null;
		IToken char_literal246=null;
		IToken LT247=null;
		JavaScriptParser.assignmentExpressionNoIn_return assignmentExpressionNoIn244 = default(JavaScriptParser.assignmentExpressionNoIn_return);
		JavaScriptParser.assignmentExpressionNoIn_return assignmentExpressionNoIn248 = default(JavaScriptParser.assignmentExpressionNoIn_return);

		object LT245_tree=null;
		object char_literal246_tree=null;
		object LT247_tree=null;

		try { DebugEnterRule(GrammarFileName, "expressionNoIn");
		DebugLocation(204, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 42)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:205:2: ( assignmentExpressionNoIn ( ( LT )* ',' ( LT )* assignmentExpressionNoIn )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:205:4: assignmentExpressionNoIn ( ( LT )* ',' ( LT )* assignmentExpressionNoIn )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(205, 4);
			PushFollow(Follow._assignmentExpressionNoIn_in_expressionNoIn1280);
			assignmentExpressionNoIn244=assignmentExpressionNoIn();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpressionNoIn244.Tree);
			DebugLocation(205, 29);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:205:29: ( ( LT )* ',' ( LT )* assignmentExpressionNoIn )*
			try { DebugEnterSubRule(118);
			while (true)
			{
				int alt118=2;
				try { DebugEnterDecision(118, decisionCanBacktrack[118]);
				try
				{
					alt118 = dfa118.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(118); }
				switch ( alt118 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:205:30: ( LT )* ',' ( LT )* assignmentExpressionNoIn
					{
					DebugLocation(205, 32);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:205:32: ( LT )*
					try { DebugEnterSubRule(116);
					while (true)
					{
						int alt116=2;
						try { DebugEnterDecision(116, decisionCanBacktrack[116]);
						int LA116_0 = input.LA(1);

						if ((LA116_0==LT))
						{
							alt116=1;
						}


						} finally { DebugExitDecision(116); }
						switch ( alt116 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(205, 32);
							LT245=(IToken)Match(input,LT,Follow._LT_in_expressionNoIn1283); if (state.failed) return retval;

							}
							break;

						default:
							goto loop116;
						}
					}

					loop116:
						;

					} finally { DebugExitSubRule(116); }

					DebugLocation(205, 35);
					char_literal246=(IToken)Match(input,33,Follow._33_in_expressionNoIn1287); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					char_literal246_tree = (object)adaptor.Create(char_literal246);
					adaptor.AddChild(root_0, char_literal246_tree);
					}
					DebugLocation(205, 41);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:205:41: ( LT )*
					try { DebugEnterSubRule(117);
					while (true)
					{
						int alt117=2;
						try { DebugEnterDecision(117, decisionCanBacktrack[117]);
						int LA117_0 = input.LA(1);

						if ((LA117_0==LT))
						{
							alt117=1;
						}


						} finally { DebugExitDecision(117); }
						switch ( alt117 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(205, 41);
							LT247=(IToken)Match(input,LT,Follow._LT_in_expressionNoIn1289); if (state.failed) return retval;

							}
							break;

						default:
							goto loop117;
						}
					}

					loop117:
						;

					} finally { DebugExitSubRule(117); }

					DebugLocation(205, 44);
					PushFollow(Follow._assignmentExpressionNoIn_in_expressionNoIn1293);
					assignmentExpressionNoIn248=assignmentExpressionNoIn();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpressionNoIn248.Tree);

					}
					break;

				default:
					goto loop118;
				}
			}

			loop118:
				;

			} finally { DebugExitSubRule(118); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expressionNoIn", 42);
			LeaveRule("expressionNoIn", 42);
			Leave_expressionNoIn();
			if (state.backtracking > 0) { Memoize(input, 42, expressionNoIn_StartIndex); }
		}
		DebugLocation(206, 1);
		} finally { DebugExitRule(GrammarFileName, "expressionNoIn"); }
		return retval;

	}
	// $ANTLR end "expressionNoIn"

	public class assignmentExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assignmentExpression();
	partial void Leave_assignmentExpression();

	// $ANTLR start "assignmentExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:208:1: assignmentExpression : ( conditionalExpression | leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpression );
	[GrammarRule("assignmentExpression")]
	private JavaScriptParser.assignmentExpression_return assignmentExpression()
	{
		Enter_assignmentExpression();
		EnterRule("assignmentExpression", 43);
		TraceIn("assignmentExpression", 43);
		JavaScriptParser.assignmentExpression_return retval = new JavaScriptParser.assignmentExpression_return();
		retval.Start = (IToken)input.LT(1);
		int assignmentExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken LT251=null;
		IToken LT253=null;
		JavaScriptParser.conditionalExpression_return conditionalExpression249 = default(JavaScriptParser.conditionalExpression_return);
		JavaScriptParser.leftHandSideExpression_return leftHandSideExpression250 = default(JavaScriptParser.leftHandSideExpression_return);
		JavaScriptParser.assignmentOperator_return assignmentOperator252 = default(JavaScriptParser.assignmentOperator_return);
		JavaScriptParser.assignmentExpression_return assignmentExpression254 = default(JavaScriptParser.assignmentExpression_return);

		object LT251_tree=null;
		object LT253_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignmentExpression");
		DebugLocation(208, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 43)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:209:2: ( conditionalExpression | leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpression )
			int alt121=2;
			try { DebugEnterDecision(121, decisionCanBacktrack[121]);
			try
			{
				alt121 = dfa121.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(121); }
			switch (alt121)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:209:4: conditionalExpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(209, 4);
				PushFollow(Follow._conditionalExpression_in_assignmentExpression1307);
				conditionalExpression249=conditionalExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpression249.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:210:4: leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(210, 4);
				PushFollow(Follow._leftHandSideExpression_in_assignmentExpression1312);
				leftHandSideExpression250=leftHandSideExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftHandSideExpression250.Tree);
				DebugLocation(210, 29);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:210:29: ( LT )*
				try { DebugEnterSubRule(119);
				while (true)
				{
					int alt119=2;
					try { DebugEnterDecision(119, decisionCanBacktrack[119]);
					int LA119_0 = input.LA(1);

					if ((LA119_0==LT))
					{
						alt119=1;
					}


					} finally { DebugExitDecision(119); }
					switch ( alt119 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(210, 29);
						LT251=(IToken)Match(input,LT,Follow._LT_in_assignmentExpression1314); if (state.failed) return retval;

						}
						break;

					default:
						goto loop119;
					}
				}

				loop119:
					;

				} finally { DebugExitSubRule(119); }

				DebugLocation(210, 32);
				PushFollow(Follow._assignmentOperator_in_assignmentExpression1318);
				assignmentOperator252=assignmentOperator();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentOperator252.Tree);
				DebugLocation(210, 53);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:210:53: ( LT )*
				try { DebugEnterSubRule(120);
				while (true)
				{
					int alt120=2;
					try { DebugEnterDecision(120, decisionCanBacktrack[120]);
					int LA120_0 = input.LA(1);

					if ((LA120_0==LT))
					{
						alt120=1;
					}


					} finally { DebugExitDecision(120); }
					switch ( alt120 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(210, 53);
						LT253=(IToken)Match(input,LT,Follow._LT_in_assignmentExpression1320); if (state.failed) return retval;

						}
						break;

					default:
						goto loop120;
					}
				}

				loop120:
					;

				} finally { DebugExitSubRule(120); }

				DebugLocation(210, 56);
				PushFollow(Follow._assignmentExpression_in_assignmentExpression1324);
				assignmentExpression254=assignmentExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression254.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assignmentExpression", 43);
			LeaveRule("assignmentExpression", 43);
			Leave_assignmentExpression();
			if (state.backtracking > 0) { Memoize(input, 43, assignmentExpression_StartIndex); }
		}
		DebugLocation(211, 1);
		} finally { DebugExitRule(GrammarFileName, "assignmentExpression"); }
		return retval;

	}
	// $ANTLR end "assignmentExpression"

	public class assignmentExpressionNoIn_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assignmentExpressionNoIn();
	partial void Leave_assignmentExpressionNoIn();

	// $ANTLR start "assignmentExpressionNoIn"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:213:1: assignmentExpressionNoIn : ( conditionalExpressionNoIn | leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpressionNoIn );
	[GrammarRule("assignmentExpressionNoIn")]
	private JavaScriptParser.assignmentExpressionNoIn_return assignmentExpressionNoIn()
	{
		Enter_assignmentExpressionNoIn();
		EnterRule("assignmentExpressionNoIn", 44);
		TraceIn("assignmentExpressionNoIn", 44);
		JavaScriptParser.assignmentExpressionNoIn_return retval = new JavaScriptParser.assignmentExpressionNoIn_return();
		retval.Start = (IToken)input.LT(1);
		int assignmentExpressionNoIn_StartIndex = input.Index;
		object root_0 = null;

		IToken LT257=null;
		IToken LT259=null;
		JavaScriptParser.conditionalExpressionNoIn_return conditionalExpressionNoIn255 = default(JavaScriptParser.conditionalExpressionNoIn_return);
		JavaScriptParser.leftHandSideExpression_return leftHandSideExpression256 = default(JavaScriptParser.leftHandSideExpression_return);
		JavaScriptParser.assignmentOperator_return assignmentOperator258 = default(JavaScriptParser.assignmentOperator_return);
		JavaScriptParser.assignmentExpressionNoIn_return assignmentExpressionNoIn260 = default(JavaScriptParser.assignmentExpressionNoIn_return);

		object LT257_tree=null;
		object LT259_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignmentExpressionNoIn");
		DebugLocation(213, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 44)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:214:2: ( conditionalExpressionNoIn | leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpressionNoIn )
			int alt124=2;
			try { DebugEnterDecision(124, decisionCanBacktrack[124]);
			try
			{
				alt124 = dfa124.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(124); }
			switch (alt124)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:214:4: conditionalExpressionNoIn
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(214, 4);
				PushFollow(Follow._conditionalExpressionNoIn_in_assignmentExpressionNoIn1336);
				conditionalExpressionNoIn255=conditionalExpressionNoIn();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpressionNoIn255.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:215:4: leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpressionNoIn
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(215, 4);
				PushFollow(Follow._leftHandSideExpression_in_assignmentExpressionNoIn1341);
				leftHandSideExpression256=leftHandSideExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftHandSideExpression256.Tree);
				DebugLocation(215, 29);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:215:29: ( LT )*
				try { DebugEnterSubRule(122);
				while (true)
				{
					int alt122=2;
					try { DebugEnterDecision(122, decisionCanBacktrack[122]);
					int LA122_0 = input.LA(1);

					if ((LA122_0==LT))
					{
						alt122=1;
					}


					} finally { DebugExitDecision(122); }
					switch ( alt122 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(215, 29);
						LT257=(IToken)Match(input,LT,Follow._LT_in_assignmentExpressionNoIn1343); if (state.failed) return retval;

						}
						break;

					default:
						goto loop122;
					}
				}

				loop122:
					;

				} finally { DebugExitSubRule(122); }

				DebugLocation(215, 32);
				PushFollow(Follow._assignmentOperator_in_assignmentExpressionNoIn1347);
				assignmentOperator258=assignmentOperator();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentOperator258.Tree);
				DebugLocation(215, 53);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:215:53: ( LT )*
				try { DebugEnterSubRule(123);
				while (true)
				{
					int alt123=2;
					try { DebugEnterDecision(123, decisionCanBacktrack[123]);
					int LA123_0 = input.LA(1);

					if ((LA123_0==LT))
					{
						alt123=1;
					}


					} finally { DebugExitDecision(123); }
					switch ( alt123 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(215, 53);
						LT259=(IToken)Match(input,LT,Follow._LT_in_assignmentExpressionNoIn1349); if (state.failed) return retval;

						}
						break;

					default:
						goto loop123;
					}
				}

				loop123:
					;

				} finally { DebugExitSubRule(123); }

				DebugLocation(215, 56);
				PushFollow(Follow._assignmentExpressionNoIn_in_assignmentExpressionNoIn1353);
				assignmentExpressionNoIn260=assignmentExpressionNoIn();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpressionNoIn260.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assignmentExpressionNoIn", 44);
			LeaveRule("assignmentExpressionNoIn", 44);
			Leave_assignmentExpressionNoIn();
			if (state.backtracking > 0) { Memoize(input, 44, assignmentExpressionNoIn_StartIndex); }
		}
		DebugLocation(216, 1);
		} finally { DebugExitRule(GrammarFileName, "assignmentExpressionNoIn"); }
		return retval;

	}
	// $ANTLR end "assignmentExpressionNoIn"

	public class leftHandSideExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_leftHandSideExpression();
	partial void Leave_leftHandSideExpression();

	// $ANTLR start "leftHandSideExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:218:1: leftHandSideExpression : ( callExpression | newExpression );
	[GrammarRule("leftHandSideExpression")]
	private JavaScriptParser.leftHandSideExpression_return leftHandSideExpression()
	{
		Enter_leftHandSideExpression();
		EnterRule("leftHandSideExpression", 45);
		TraceIn("leftHandSideExpression", 45);
		JavaScriptParser.leftHandSideExpression_return retval = new JavaScriptParser.leftHandSideExpression_return();
		retval.Start = (IToken)input.LT(1);
		int leftHandSideExpression_StartIndex = input.Index;
		object root_0 = null;

		JavaScriptParser.callExpression_return callExpression261 = default(JavaScriptParser.callExpression_return);
		JavaScriptParser.newExpression_return newExpression262 = default(JavaScriptParser.newExpression_return);


		try { DebugEnterRule(GrammarFileName, "leftHandSideExpression");
		DebugLocation(218, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 45)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:219:2: ( callExpression | newExpression )
			int alt125=2;
			try { DebugEnterDecision(125, decisionCanBacktrack[125]);
			try
			{
				alt125 = dfa125.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(125); }
			switch (alt125)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:219:4: callExpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(219, 4);
				PushFollow(Follow._callExpression_in_leftHandSideExpression1365);
				callExpression261=callExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callExpression261.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:220:4: newExpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(220, 4);
				PushFollow(Follow._newExpression_in_leftHandSideExpression1370);
				newExpression262=newExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newExpression262.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("leftHandSideExpression", 45);
			LeaveRule("leftHandSideExpression", 45);
			Leave_leftHandSideExpression();
			if (state.backtracking > 0) { Memoize(input, 45, leftHandSideExpression_StartIndex); }
		}
		DebugLocation(221, 1);
		} finally { DebugExitRule(GrammarFileName, "leftHandSideExpression"); }
		return retval;

	}
	// $ANTLR end "leftHandSideExpression"

	public class newExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_newExpression();
	partial void Leave_newExpression();

	// $ANTLR start "newExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:223:1: newExpression : ( memberExpression | 'new' ( LT )* newExpression );
	[GrammarRule("newExpression")]
	private JavaScriptParser.newExpression_return newExpression()
	{
		Enter_newExpression();
		EnterRule("newExpression", 46);
		TraceIn("newExpression", 46);
		JavaScriptParser.newExpression_return retval = new JavaScriptParser.newExpression_return();
		retval.Start = (IToken)input.LT(1);
		int newExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal264=null;
		IToken LT265=null;
		JavaScriptParser.memberExpression_return memberExpression263 = default(JavaScriptParser.memberExpression_return);
		JavaScriptParser.newExpression_return newExpression266 = default(JavaScriptParser.newExpression_return);

		object string_literal264_tree=null;
		object LT265_tree=null;

		try { DebugEnterRule(GrammarFileName, "newExpression");
		DebugLocation(223, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 46)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:224:2: ( memberExpression | 'new' ( LT )* newExpression )
			int alt127=2;
			try { DebugEnterDecision(127, decisionCanBacktrack[127]);
			try
			{
				alt127 = dfa127.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(127); }
			switch (alt127)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:224:4: memberExpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(224, 4);
				PushFollow(Follow._memberExpression_in_newExpression1382);
				memberExpression263=memberExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberExpression263.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:225:4: 'new' ( LT )* newExpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(225, 4);
				string_literal264=(IToken)Match(input,58,Follow._58_in_newExpression1387); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				string_literal264_tree = (object)adaptor.Create(string_literal264);
				adaptor.AddChild(root_0, string_literal264_tree);
				}
				DebugLocation(225, 12);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:225:12: ( LT )*
				try { DebugEnterSubRule(126);
				while (true)
				{
					int alt126=2;
					try { DebugEnterDecision(126, decisionCanBacktrack[126]);
					int LA126_0 = input.LA(1);

					if ((LA126_0==LT))
					{
						alt126=1;
					}


					} finally { DebugExitDecision(126); }
					switch ( alt126 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(225, 12);
						LT265=(IToken)Match(input,LT,Follow._LT_in_newExpression1389); if (state.failed) return retval;

						}
						break;

					default:
						goto loop126;
					}
				}

				loop126:
					;

				} finally { DebugExitSubRule(126); }

				DebugLocation(225, 15);
				PushFollow(Follow._newExpression_in_newExpression1393);
				newExpression266=newExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newExpression266.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("newExpression", 46);
			LeaveRule("newExpression", 46);
			Leave_newExpression();
			if (state.backtracking > 0) { Memoize(input, 46, newExpression_StartIndex); }
		}
		DebugLocation(226, 1);
		} finally { DebugExitRule(GrammarFileName, "newExpression"); }
		return retval;

	}
	// $ANTLR end "newExpression"

	public class memberExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_memberExpression();
	partial void Leave_memberExpression();

	// $ANTLR start "memberExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:228:1: memberExpression : ( primaryExpression | functionExpression | 'new' ( LT )* memberExpression ( LT )* arguments ) ( ( LT )* memberExpressionSuffix )* ;
	[GrammarRule("memberExpression")]
	private JavaScriptParser.memberExpression_return memberExpression()
	{
		Enter_memberExpression();
		EnterRule("memberExpression", 47);
		TraceIn("memberExpression", 47);
		JavaScriptParser.memberExpression_return retval = new JavaScriptParser.memberExpression_return();
		retval.Start = (IToken)input.LT(1);
		int memberExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal269=null;
		IToken LT270=null;
		IToken LT272=null;
		IToken LT274=null;
		JavaScriptParser.primaryExpression_return primaryExpression267 = default(JavaScriptParser.primaryExpression_return);
		JavaScriptParser.functionExpression_return functionExpression268 = default(JavaScriptParser.functionExpression_return);
		JavaScriptParser.memberExpression_return memberExpression271 = default(JavaScriptParser.memberExpression_return);
		JavaScriptParser.arguments_return arguments273 = default(JavaScriptParser.arguments_return);
		JavaScriptParser.memberExpressionSuffix_return memberExpressionSuffix275 = default(JavaScriptParser.memberExpressionSuffix_return);

		object string_literal269_tree=null;
		object LT270_tree=null;
		object LT272_tree=null;
		object LT274_tree=null;

		try { DebugEnterRule(GrammarFileName, "memberExpression");
		DebugLocation(228, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 47)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:229:2: ( ( primaryExpression | functionExpression | 'new' ( LT )* memberExpression ( LT )* arguments ) ( ( LT )* memberExpressionSuffix )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:229:4: ( primaryExpression | functionExpression | 'new' ( LT )* memberExpression ( LT )* arguments ) ( ( LT )* memberExpressionSuffix )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(229, 4);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:229:4: ( primaryExpression | functionExpression | 'new' ( LT )* memberExpression ( LT )* arguments )
			int alt130=3;
			try { DebugEnterSubRule(130);
			try { DebugEnterDecision(130, decisionCanBacktrack[130]);
			switch (input.LA(1))
			{
			case Identifier:
			case StringLiteral:
			case NumericLiteral:
			case 32:
			case 35:
			case 59:
			case 103:
			case 104:
			case 105:
			case 106:
				{
				alt130=1;
				}
				break;
			case 31:
				{
				alt130=2;
				}
				break;
			case 58:
				{
				alt130=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 130, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(130); }
			switch (alt130)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:229:5: primaryExpression
				{
				DebugLocation(229, 5);
				PushFollow(Follow._primaryExpression_in_memberExpression1406);
				primaryExpression267=primaryExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression267.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:229:25: functionExpression
				{
				DebugLocation(229, 25);
				PushFollow(Follow._functionExpression_in_memberExpression1410);
				functionExpression268=functionExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionExpression268.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:229:46: 'new' ( LT )* memberExpression ( LT )* arguments
				{
				DebugLocation(229, 46);
				string_literal269=(IToken)Match(input,58,Follow._58_in_memberExpression1414); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				string_literal269_tree = (object)adaptor.Create(string_literal269);
				adaptor.AddChild(root_0, string_literal269_tree);
				}
				DebugLocation(229, 54);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:229:54: ( LT )*
				try { DebugEnterSubRule(128);
				while (true)
				{
					int alt128=2;
					try { DebugEnterDecision(128, decisionCanBacktrack[128]);
					int LA128_0 = input.LA(1);

					if ((LA128_0==LT))
					{
						alt128=1;
					}


					} finally { DebugExitDecision(128); }
					switch ( alt128 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(229, 54);
						LT270=(IToken)Match(input,LT,Follow._LT_in_memberExpression1416); if (state.failed) return retval;

						}
						break;

					default:
						goto loop128;
					}
				}

				loop128:
					;

				} finally { DebugExitSubRule(128); }

				DebugLocation(229, 57);
				PushFollow(Follow._memberExpression_in_memberExpression1420);
				memberExpression271=memberExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberExpression271.Tree);
				DebugLocation(229, 76);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:229:76: ( LT )*
				try { DebugEnterSubRule(129);
				while (true)
				{
					int alt129=2;
					try { DebugEnterDecision(129, decisionCanBacktrack[129]);
					int LA129_0 = input.LA(1);

					if ((LA129_0==LT))
					{
						alt129=1;
					}


					} finally { DebugExitDecision(129); }
					switch ( alt129 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(229, 76);
						LT272=(IToken)Match(input,LT,Follow._LT_in_memberExpression1422); if (state.failed) return retval;

						}
						break;

					default:
						goto loop129;
					}
				}

				loop129:
					;

				} finally { DebugExitSubRule(129); }

				DebugLocation(229, 79);
				PushFollow(Follow._arguments_in_memberExpression1426);
				arguments273=arguments();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arguments273.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(130); }

			DebugLocation(229, 90);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:229:90: ( ( LT )* memberExpressionSuffix )*
			try { DebugEnterSubRule(132);
			while (true)
			{
				int alt132=2;
				try { DebugEnterDecision(132, decisionCanBacktrack[132]);
				try
				{
					alt132 = dfa132.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(132); }
				switch ( alt132 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:229:91: ( LT )* memberExpressionSuffix
					{
					DebugLocation(229, 93);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:229:93: ( LT )*
					try { DebugEnterSubRule(131);
					while (true)
					{
						int alt131=2;
						try { DebugEnterDecision(131, decisionCanBacktrack[131]);
						int LA131_0 = input.LA(1);

						if ((LA131_0==LT))
						{
							alt131=1;
						}


						} finally { DebugExitDecision(131); }
						switch ( alt131 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(229, 93);
							LT274=(IToken)Match(input,LT,Follow._LT_in_memberExpression1430); if (state.failed) return retval;

							}
							break;

						default:
							goto loop131;
						}
					}

					loop131:
						;

					} finally { DebugExitSubRule(131); }

					DebugLocation(229, 96);
					PushFollow(Follow._memberExpressionSuffix_in_memberExpression1434);
					memberExpressionSuffix275=memberExpressionSuffix();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberExpressionSuffix275.Tree);

					}
					break;

				default:
					goto loop132;
				}
			}

			loop132:
				;

			} finally { DebugExitSubRule(132); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("memberExpression", 47);
			LeaveRule("memberExpression", 47);
			Leave_memberExpression();
			if (state.backtracking > 0) { Memoize(input, 47, memberExpression_StartIndex); }
		}
		DebugLocation(230, 1);
		} finally { DebugExitRule(GrammarFileName, "memberExpression"); }
		return retval;

	}
	// $ANTLR end "memberExpression"

	public class memberExpressionSuffix_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_memberExpressionSuffix();
	partial void Leave_memberExpressionSuffix();

	// $ANTLR start "memberExpressionSuffix"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:232:1: memberExpressionSuffix : ( indexSuffix | propertyReferenceSuffix );
	[GrammarRule("memberExpressionSuffix")]
	private JavaScriptParser.memberExpressionSuffix_return memberExpressionSuffix()
	{
		Enter_memberExpressionSuffix();
		EnterRule("memberExpressionSuffix", 48);
		TraceIn("memberExpressionSuffix", 48);
		JavaScriptParser.memberExpressionSuffix_return retval = new JavaScriptParser.memberExpressionSuffix_return();
		retval.Start = (IToken)input.LT(1);
		int memberExpressionSuffix_StartIndex = input.Index;
		object root_0 = null;

		JavaScriptParser.indexSuffix_return indexSuffix276 = default(JavaScriptParser.indexSuffix_return);
		JavaScriptParser.propertyReferenceSuffix_return propertyReferenceSuffix277 = default(JavaScriptParser.propertyReferenceSuffix_return);


		try { DebugEnterRule(GrammarFileName, "memberExpressionSuffix");
		DebugLocation(232, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 48)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:233:2: ( indexSuffix | propertyReferenceSuffix )
			int alt133=2;
			try { DebugEnterDecision(133, decisionCanBacktrack[133]);
			int LA133_0 = input.LA(1);

			if ((LA133_0==59))
			{
				alt133=1;
			}
			else if ((LA133_0==61))
			{
				alt133=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 133, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(133); }
			switch (alt133)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:233:4: indexSuffix
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(233, 4);
				PushFollow(Follow._indexSuffix_in_memberExpressionSuffix1448);
				indexSuffix276=indexSuffix();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, indexSuffix276.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:234:4: propertyReferenceSuffix
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(234, 4);
				PushFollow(Follow._propertyReferenceSuffix_in_memberExpressionSuffix1453);
				propertyReferenceSuffix277=propertyReferenceSuffix();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, propertyReferenceSuffix277.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("memberExpressionSuffix", 48);
			LeaveRule("memberExpressionSuffix", 48);
			Leave_memberExpressionSuffix();
			if (state.backtracking > 0) { Memoize(input, 48, memberExpressionSuffix_StartIndex); }
		}
		DebugLocation(235, 1);
		} finally { DebugExitRule(GrammarFileName, "memberExpressionSuffix"); }
		return retval;

	}
	// $ANTLR end "memberExpressionSuffix"

	public class callExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_callExpression();
	partial void Leave_callExpression();

	// $ANTLR start "callExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:237:1: callExpression : memberExpression ( LT )* arguments ( ( LT )* callExpressionSuffix )* ;
	[GrammarRule("callExpression")]
	private JavaScriptParser.callExpression_return callExpression()
	{
		Enter_callExpression();
		EnterRule("callExpression", 49);
		TraceIn("callExpression", 49);
		JavaScriptParser.callExpression_return retval = new JavaScriptParser.callExpression_return();
		retval.Start = (IToken)input.LT(1);
		int callExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken LT279=null;
		IToken LT281=null;
		JavaScriptParser.memberExpression_return memberExpression278 = default(JavaScriptParser.memberExpression_return);
		JavaScriptParser.arguments_return arguments280 = default(JavaScriptParser.arguments_return);
		JavaScriptParser.callExpressionSuffix_return callExpressionSuffix282 = default(JavaScriptParser.callExpressionSuffix_return);

		object LT279_tree=null;
		object LT281_tree=null;

		try { DebugEnterRule(GrammarFileName, "callExpression");
		DebugLocation(237, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 49)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:238:2: ( memberExpression ( LT )* arguments ( ( LT )* callExpressionSuffix )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:238:4: memberExpression ( LT )* arguments ( ( LT )* callExpressionSuffix )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(238, 4);
			PushFollow(Follow._memberExpression_in_callExpression1464);
			memberExpression278=memberExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberExpression278.Tree);
			DebugLocation(238, 23);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:238:23: ( LT )*
			try { DebugEnterSubRule(134);
			while (true)
			{
				int alt134=2;
				try { DebugEnterDecision(134, decisionCanBacktrack[134]);
				int LA134_0 = input.LA(1);

				if ((LA134_0==LT))
				{
					alt134=1;
				}


				} finally { DebugExitDecision(134); }
				switch ( alt134 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(238, 23);
					LT279=(IToken)Match(input,LT,Follow._LT_in_callExpression1466); if (state.failed) return retval;

					}
					break;

				default:
					goto loop134;
				}
			}

			loop134:
				;

			} finally { DebugExitSubRule(134); }

			DebugLocation(238, 26);
			PushFollow(Follow._arguments_in_callExpression1470);
			arguments280=arguments();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arguments280.Tree);
			DebugLocation(238, 36);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:238:36: ( ( LT )* callExpressionSuffix )*
			try { DebugEnterSubRule(136);
			while (true)
			{
				int alt136=2;
				try { DebugEnterDecision(136, decisionCanBacktrack[136]);
				try
				{
					alt136 = dfa136.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(136); }
				switch ( alt136 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:238:37: ( LT )* callExpressionSuffix
					{
					DebugLocation(238, 39);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:238:39: ( LT )*
					try { DebugEnterSubRule(135);
					while (true)
					{
						int alt135=2;
						try { DebugEnterDecision(135, decisionCanBacktrack[135]);
						int LA135_0 = input.LA(1);

						if ((LA135_0==LT))
						{
							alt135=1;
						}


						} finally { DebugExitDecision(135); }
						switch ( alt135 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(238, 39);
							LT281=(IToken)Match(input,LT,Follow._LT_in_callExpression1473); if (state.failed) return retval;

							}
							break;

						default:
							goto loop135;
						}
					}

					loop135:
						;

					} finally { DebugExitSubRule(135); }

					DebugLocation(238, 42);
					PushFollow(Follow._callExpressionSuffix_in_callExpression1477);
					callExpressionSuffix282=callExpressionSuffix();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callExpressionSuffix282.Tree);

					}
					break;

				default:
					goto loop136;
				}
			}

			loop136:
				;

			} finally { DebugExitSubRule(136); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("callExpression", 49);
			LeaveRule("callExpression", 49);
			Leave_callExpression();
			if (state.backtracking > 0) { Memoize(input, 49, callExpression_StartIndex); }
		}
		DebugLocation(239, 1);
		} finally { DebugExitRule(GrammarFileName, "callExpression"); }
		return retval;

	}
	// $ANTLR end "callExpression"

	public class callExpressionSuffix_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_callExpressionSuffix();
	partial void Leave_callExpressionSuffix();

	// $ANTLR start "callExpressionSuffix"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:241:1: callExpressionSuffix : ( arguments | indexSuffix | propertyReferenceSuffix );
	[GrammarRule("callExpressionSuffix")]
	private JavaScriptParser.callExpressionSuffix_return callExpressionSuffix()
	{
		Enter_callExpressionSuffix();
		EnterRule("callExpressionSuffix", 50);
		TraceIn("callExpressionSuffix", 50);
		JavaScriptParser.callExpressionSuffix_return retval = new JavaScriptParser.callExpressionSuffix_return();
		retval.Start = (IToken)input.LT(1);
		int callExpressionSuffix_StartIndex = input.Index;
		object root_0 = null;

		JavaScriptParser.arguments_return arguments283 = default(JavaScriptParser.arguments_return);
		JavaScriptParser.indexSuffix_return indexSuffix284 = default(JavaScriptParser.indexSuffix_return);
		JavaScriptParser.propertyReferenceSuffix_return propertyReferenceSuffix285 = default(JavaScriptParser.propertyReferenceSuffix_return);


		try { DebugEnterRule(GrammarFileName, "callExpressionSuffix");
		DebugLocation(241, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 50)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:242:2: ( arguments | indexSuffix | propertyReferenceSuffix )
			int alt137=3;
			try { DebugEnterDecision(137, decisionCanBacktrack[137]);
			switch (input.LA(1))
			{
			case 32:
				{
				alt137=1;
				}
				break;
			case 59:
				{
				alt137=2;
				}
				break;
			case 61:
				{
				alt137=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 137, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(137); }
			switch (alt137)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:242:4: arguments
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(242, 4);
				PushFollow(Follow._arguments_in_callExpressionSuffix1491);
				arguments283=arguments();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arguments283.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:243:4: indexSuffix
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(243, 4);
				PushFollow(Follow._indexSuffix_in_callExpressionSuffix1496);
				indexSuffix284=indexSuffix();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, indexSuffix284.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:244:4: propertyReferenceSuffix
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(244, 4);
				PushFollow(Follow._propertyReferenceSuffix_in_callExpressionSuffix1501);
				propertyReferenceSuffix285=propertyReferenceSuffix();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, propertyReferenceSuffix285.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("callExpressionSuffix", 50);
			LeaveRule("callExpressionSuffix", 50);
			Leave_callExpressionSuffix();
			if (state.backtracking > 0) { Memoize(input, 50, callExpressionSuffix_StartIndex); }
		}
		DebugLocation(245, 1);
		} finally { DebugExitRule(GrammarFileName, "callExpressionSuffix"); }
		return retval;

	}
	// $ANTLR end "callExpressionSuffix"

	public class arguments_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arguments();
	partial void Leave_arguments();

	// $ANTLR start "arguments"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:247:1: arguments : '(' ( ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )? ( LT )* ')' ;
	[GrammarRule("arguments")]
	private JavaScriptParser.arguments_return arguments()
	{
		Enter_arguments();
		EnterRule("arguments", 51);
		TraceIn("arguments", 51);
		JavaScriptParser.arguments_return retval = new JavaScriptParser.arguments_return();
		retval.Start = (IToken)input.LT(1);
		int arguments_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal286=null;
		IToken LT287=null;
		IToken LT289=null;
		IToken char_literal290=null;
		IToken LT291=null;
		IToken LT293=null;
		IToken char_literal294=null;
		JavaScriptParser.assignmentExpression_return assignmentExpression288 = default(JavaScriptParser.assignmentExpression_return);
		JavaScriptParser.assignmentExpression_return assignmentExpression292 = default(JavaScriptParser.assignmentExpression_return);

		object char_literal286_tree=null;
		object LT287_tree=null;
		object LT289_tree=null;
		object char_literal290_tree=null;
		object LT291_tree=null;
		object LT293_tree=null;
		object char_literal294_tree=null;

		try { DebugEnterRule(GrammarFileName, "arguments");
		DebugLocation(247, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 51)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:248:2: ( '(' ( ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )? ( LT )* ')' )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:248:4: '(' ( ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )? ( LT )* ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(248, 4);
			char_literal286=(IToken)Match(input,32,Follow._32_in_arguments1512); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal286_tree = (object)adaptor.Create(char_literal286);
			adaptor.AddChild(root_0, char_literal286_tree);
			}
			DebugLocation(248, 8);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:248:8: ( ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )?
			int alt142=2;
			try { DebugEnterSubRule(142);
			try { DebugEnterDecision(142, decisionCanBacktrack[142]);
			try
			{
				alt142 = dfa142.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(142); }
			switch (alt142)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:248:9: ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )*
				{
				DebugLocation(248, 11);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:248:11: ( LT )*
				try { DebugEnterSubRule(138);
				while (true)
				{
					int alt138=2;
					try { DebugEnterDecision(138, decisionCanBacktrack[138]);
					int LA138_0 = input.LA(1);

					if ((LA138_0==LT))
					{
						alt138=1;
					}


					} finally { DebugExitDecision(138); }
					switch ( alt138 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(248, 11);
						LT287=(IToken)Match(input,LT,Follow._LT_in_arguments1515); if (state.failed) return retval;

						}
						break;

					default:
						goto loop138;
					}
				}

				loop138:
					;

				} finally { DebugExitSubRule(138); }

				DebugLocation(248, 14);
				PushFollow(Follow._assignmentExpression_in_arguments1519);
				assignmentExpression288=assignmentExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression288.Tree);
				DebugLocation(248, 35);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:248:35: ( ( LT )* ',' ( LT )* assignmentExpression )*
				try { DebugEnterSubRule(141);
				while (true)
				{
					int alt141=2;
					try { DebugEnterDecision(141, decisionCanBacktrack[141]);
					try
					{
						alt141 = dfa141.Predict(input);
					}
					catch (NoViableAltException nvae)
					{
						DebugRecognitionException(nvae);
						throw;
					}
					} finally { DebugExitDecision(141); }
					switch ( alt141 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:248:36: ( LT )* ',' ( LT )* assignmentExpression
						{
						DebugLocation(248, 38);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:248:38: ( LT )*
						try { DebugEnterSubRule(139);
						while (true)
						{
							int alt139=2;
							try { DebugEnterDecision(139, decisionCanBacktrack[139]);
							int LA139_0 = input.LA(1);

							if ((LA139_0==LT))
							{
								alt139=1;
							}


							} finally { DebugExitDecision(139); }
							switch ( alt139 )
							{
							case 1:
								DebugEnterAlt(1);
								// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
								{
								DebugLocation(248, 38);
								LT289=(IToken)Match(input,LT,Follow._LT_in_arguments1522); if (state.failed) return retval;

								}
								break;

							default:
								goto loop139;
							}
						}

						loop139:
							;

						} finally { DebugExitSubRule(139); }

						DebugLocation(248, 41);
						char_literal290=(IToken)Match(input,33,Follow._33_in_arguments1526); if (state.failed) return retval;
						if ( state.backtracking==0 ) {
						char_literal290_tree = (object)adaptor.Create(char_literal290);
						adaptor.AddChild(root_0, char_literal290_tree);
						}
						DebugLocation(248, 47);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:248:47: ( LT )*
						try { DebugEnterSubRule(140);
						while (true)
						{
							int alt140=2;
							try { DebugEnterDecision(140, decisionCanBacktrack[140]);
							int LA140_0 = input.LA(1);

							if ((LA140_0==LT))
							{
								alt140=1;
							}


							} finally { DebugExitDecision(140); }
							switch ( alt140 )
							{
							case 1:
								DebugEnterAlt(1);
								// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
								{
								DebugLocation(248, 47);
								LT291=(IToken)Match(input,LT,Follow._LT_in_arguments1528); if (state.failed) return retval;

								}
								break;

							default:
								goto loop140;
							}
						}

						loop140:
							;

						} finally { DebugExitSubRule(140); }

						DebugLocation(248, 50);
						PushFollow(Follow._assignmentExpression_in_arguments1532);
						assignmentExpression292=assignmentExpression();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression292.Tree);

						}
						break;

					default:
						goto loop141;
					}
				}

				loop141:
					;

				} finally { DebugExitSubRule(141); }


				}
				break;

			}
			} finally { DebugExitSubRule(142); }

			DebugLocation(248, 77);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:248:77: ( LT )*
			try { DebugEnterSubRule(143);
			while (true)
			{
				int alt143=2;
				try { DebugEnterDecision(143, decisionCanBacktrack[143]);
				int LA143_0 = input.LA(1);

				if ((LA143_0==LT))
				{
					alt143=1;
				}


				} finally { DebugExitDecision(143); }
				switch ( alt143 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(248, 77);
					LT293=(IToken)Match(input,LT,Follow._LT_in_arguments1538); if (state.failed) return retval;

					}
					break;

				default:
					goto loop143;
				}
			}

			loop143:
				;

			} finally { DebugExitSubRule(143); }

			DebugLocation(248, 80);
			char_literal294=(IToken)Match(input,34,Follow._34_in_arguments1542); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal294_tree = (object)adaptor.Create(char_literal294);
			adaptor.AddChild(root_0, char_literal294_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("arguments", 51);
			LeaveRule("arguments", 51);
			Leave_arguments();
			if (state.backtracking > 0) { Memoize(input, 51, arguments_StartIndex); }
		}
		DebugLocation(249, 1);
		} finally { DebugExitRule(GrammarFileName, "arguments"); }
		return retval;

	}
	// $ANTLR end "arguments"

	public class indexSuffix_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_indexSuffix();
	partial void Leave_indexSuffix();

	// $ANTLR start "indexSuffix"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:251:1: indexSuffix : '[' ( LT )* expression ( LT )* ']' ;
	[GrammarRule("indexSuffix")]
	private JavaScriptParser.indexSuffix_return indexSuffix()
	{
		Enter_indexSuffix();
		EnterRule("indexSuffix", 52);
		TraceIn("indexSuffix", 52);
		JavaScriptParser.indexSuffix_return retval = new JavaScriptParser.indexSuffix_return();
		retval.Start = (IToken)input.LT(1);
		int indexSuffix_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal295=null;
		IToken LT296=null;
		IToken LT298=null;
		IToken char_literal299=null;
		JavaScriptParser.expression_return expression297 = default(JavaScriptParser.expression_return);

		object char_literal295_tree=null;
		object LT296_tree=null;
		object LT298_tree=null;
		object char_literal299_tree=null;

		try { DebugEnterRule(GrammarFileName, "indexSuffix");
		DebugLocation(251, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 52)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:252:2: ( '[' ( LT )* expression ( LT )* ']' )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:252:4: '[' ( LT )* expression ( LT )* ']'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(252, 4);
			char_literal295=(IToken)Match(input,59,Follow._59_in_indexSuffix1554); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal295_tree = (object)adaptor.Create(char_literal295);
			adaptor.AddChild(root_0, char_literal295_tree);
			}
			DebugLocation(252, 10);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:252:10: ( LT )*
			try { DebugEnterSubRule(144);
			while (true)
			{
				int alt144=2;
				try { DebugEnterDecision(144, decisionCanBacktrack[144]);
				int LA144_0 = input.LA(1);

				if ((LA144_0==LT))
				{
					alt144=1;
				}


				} finally { DebugExitDecision(144); }
				switch ( alt144 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(252, 10);
					LT296=(IToken)Match(input,LT,Follow._LT_in_indexSuffix1556); if (state.failed) return retval;

					}
					break;

				default:
					goto loop144;
				}
			}

			loop144:
				;

			} finally { DebugExitSubRule(144); }

			DebugLocation(252, 13);
			PushFollow(Follow._expression_in_indexSuffix1560);
			expression297=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression297.Tree);
			DebugLocation(252, 26);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:252:26: ( LT )*
			try { DebugEnterSubRule(145);
			while (true)
			{
				int alt145=2;
				try { DebugEnterDecision(145, decisionCanBacktrack[145]);
				int LA145_0 = input.LA(1);

				if ((LA145_0==LT))
				{
					alt145=1;
				}


				} finally { DebugExitDecision(145); }
				switch ( alt145 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(252, 26);
					LT298=(IToken)Match(input,LT,Follow._LT_in_indexSuffix1562); if (state.failed) return retval;

					}
					break;

				default:
					goto loop145;
				}
			}

			loop145:
				;

			} finally { DebugExitSubRule(145); }

			DebugLocation(252, 29);
			char_literal299=(IToken)Match(input,60,Follow._60_in_indexSuffix1566); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal299_tree = (object)adaptor.Create(char_literal299);
			adaptor.AddChild(root_0, char_literal299_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("indexSuffix", 52);
			LeaveRule("indexSuffix", 52);
			Leave_indexSuffix();
			if (state.backtracking > 0) { Memoize(input, 52, indexSuffix_StartIndex); }
		}
		DebugLocation(253, 1);
		} finally { DebugExitRule(GrammarFileName, "indexSuffix"); }
		return retval;

	}
	// $ANTLR end "indexSuffix"

	public class propertyReferenceSuffix_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_propertyReferenceSuffix();
	partial void Leave_propertyReferenceSuffix();

	// $ANTLR start "propertyReferenceSuffix"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:255:1: propertyReferenceSuffix : '.' ( LT )* Identifier ;
	[GrammarRule("propertyReferenceSuffix")]
	private JavaScriptParser.propertyReferenceSuffix_return propertyReferenceSuffix()
	{
		Enter_propertyReferenceSuffix();
		EnterRule("propertyReferenceSuffix", 53);
		TraceIn("propertyReferenceSuffix", 53);
		JavaScriptParser.propertyReferenceSuffix_return retval = new JavaScriptParser.propertyReferenceSuffix_return();
		retval.Start = (IToken)input.LT(1);
		int propertyReferenceSuffix_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal300=null;
		IToken LT301=null;
		IToken Identifier302=null;

		object char_literal300_tree=null;
		object LT301_tree=null;
		object Identifier302_tree=null;

		try { DebugEnterRule(GrammarFileName, "propertyReferenceSuffix");
		DebugLocation(255, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 53)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:256:2: ( '.' ( LT )* Identifier )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:256:4: '.' ( LT )* Identifier
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(256, 4);
			char_literal300=(IToken)Match(input,61,Follow._61_in_propertyReferenceSuffix1579); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal300_tree = (object)adaptor.Create(char_literal300);
			adaptor.AddChild(root_0, char_literal300_tree);
			}
			DebugLocation(256, 10);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:256:10: ( LT )*
			try { DebugEnterSubRule(146);
			while (true)
			{
				int alt146=2;
				try { DebugEnterDecision(146, decisionCanBacktrack[146]);
				int LA146_0 = input.LA(1);

				if ((LA146_0==LT))
				{
					alt146=1;
				}


				} finally { DebugExitDecision(146); }
				switch ( alt146 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(256, 10);
					LT301=(IToken)Match(input,LT,Follow._LT_in_propertyReferenceSuffix1581); if (state.failed) return retval;

					}
					break;

				default:
					goto loop146;
				}
			}

			loop146:
				;

			} finally { DebugExitSubRule(146); }

			DebugLocation(256, 13);
			Identifier302=(IToken)Match(input,Identifier,Follow._Identifier_in_propertyReferenceSuffix1585); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			Identifier302_tree = (object)adaptor.Create(Identifier302);
			adaptor.AddChild(root_0, Identifier302_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("propertyReferenceSuffix", 53);
			LeaveRule("propertyReferenceSuffix", 53);
			Leave_propertyReferenceSuffix();
			if (state.backtracking > 0) { Memoize(input, 53, propertyReferenceSuffix_StartIndex); }
		}
		DebugLocation(257, 1);
		} finally { DebugExitRule(GrammarFileName, "propertyReferenceSuffix"); }
		return retval;

	}
	// $ANTLR end "propertyReferenceSuffix"

	public class assignmentOperator_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assignmentOperator();
	partial void Leave_assignmentOperator();

	// $ANTLR start "assignmentOperator"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:259:1: assignmentOperator : ( '=' | '*=' | '/=' | '%=' | '+=' | '-=' | '<<=' | '>>=' | '>>>=' | '&=' | '^=' | '|=' );
	[GrammarRule("assignmentOperator")]
	private JavaScriptParser.assignmentOperator_return assignmentOperator()
	{
		Enter_assignmentOperator();
		EnterRule("assignmentOperator", 54);
		TraceIn("assignmentOperator", 54);
		JavaScriptParser.assignmentOperator_return retval = new JavaScriptParser.assignmentOperator_return();
		retval.Start = (IToken)input.LT(1);
		int assignmentOperator_StartIndex = input.Index;
		object root_0 = null;

		IToken set303=null;

		object set303_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignmentOperator");
		DebugLocation(259, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 54)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:260:2: ( '=' | '*=' | '/=' | '%=' | '+=' | '-=' | '<<=' | '>>=' | '>>>=' | '&=' | '^=' | '|=' )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(260, 2);
			set303=(IToken)input.LT(1);
			if (input.LA(1)==39||(input.LA(1)>=62 && input.LA(1)<=72))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set303));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assignmentOperator", 54);
			LeaveRule("assignmentOperator", 54);
			Leave_assignmentOperator();
			if (state.backtracking > 0) { Memoize(input, 54, assignmentOperator_StartIndex); }
		}
		DebugLocation(261, 1);
		} finally { DebugExitRule(GrammarFileName, "assignmentOperator"); }
		return retval;

	}
	// $ANTLR end "assignmentOperator"

	public class conditionalExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_conditionalExpression();
	partial void Leave_conditionalExpression();

	// $ANTLR start "conditionalExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:263:1: conditionalExpression : logicalORExpression ( ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression )? ;
	[GrammarRule("conditionalExpression")]
	private JavaScriptParser.conditionalExpression_return conditionalExpression()
	{
		Enter_conditionalExpression();
		EnterRule("conditionalExpression", 55);
		TraceIn("conditionalExpression", 55);
		JavaScriptParser.conditionalExpression_return retval = new JavaScriptParser.conditionalExpression_return();
		retval.Start = (IToken)input.LT(1);
		int conditionalExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken LT305=null;
		IToken char_literal306=null;
		IToken LT307=null;
		IToken LT309=null;
		IToken char_literal310=null;
		IToken LT311=null;
		JavaScriptParser.logicalORExpression_return logicalORExpression304 = default(JavaScriptParser.logicalORExpression_return);
		JavaScriptParser.assignmentExpression_return assignmentExpression308 = default(JavaScriptParser.assignmentExpression_return);
		JavaScriptParser.assignmentExpression_return assignmentExpression312 = default(JavaScriptParser.assignmentExpression_return);

		object LT305_tree=null;
		object char_literal306_tree=null;
		object LT307_tree=null;
		object LT309_tree=null;
		object char_literal310_tree=null;
		object LT311_tree=null;

		try { DebugEnterRule(GrammarFileName, "conditionalExpression");
		DebugLocation(263, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 55)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:264:2: ( logicalORExpression ( ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression )? )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:264:4: logicalORExpression ( ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(264, 4);
			PushFollow(Follow._logicalORExpression_in_conditionalExpression1652);
			logicalORExpression304=logicalORExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicalORExpression304.Tree);
			DebugLocation(264, 24);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:264:24: ( ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression )?
			int alt151=2;
			try { DebugEnterSubRule(151);
			try { DebugEnterDecision(151, decisionCanBacktrack[151]);
			try
			{
				alt151 = dfa151.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(151); }
			switch (alt151)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:264:25: ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression
				{
				DebugLocation(264, 27);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:264:27: ( LT )*
				try { DebugEnterSubRule(147);
				while (true)
				{
					int alt147=2;
					try { DebugEnterDecision(147, decisionCanBacktrack[147]);
					int LA147_0 = input.LA(1);

					if ((LA147_0==LT))
					{
						alt147=1;
					}


					} finally { DebugExitDecision(147); }
					switch ( alt147 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(264, 27);
						LT305=(IToken)Match(input,LT,Follow._LT_in_conditionalExpression1655); if (state.failed) return retval;

						}
						break;

					default:
						goto loop147;
					}
				}

				loop147:
					;

				} finally { DebugExitSubRule(147); }

				DebugLocation(264, 30);
				char_literal306=(IToken)Match(input,73,Follow._73_in_conditionalExpression1659); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal306_tree = (object)adaptor.Create(char_literal306);
				adaptor.AddChild(root_0, char_literal306_tree);
				}
				DebugLocation(264, 36);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:264:36: ( LT )*
				try { DebugEnterSubRule(148);
				while (true)
				{
					int alt148=2;
					try { DebugEnterDecision(148, decisionCanBacktrack[148]);
					int LA148_0 = input.LA(1);

					if ((LA148_0==LT))
					{
						alt148=1;
					}


					} finally { DebugExitDecision(148); }
					switch ( alt148 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(264, 36);
						LT307=(IToken)Match(input,LT,Follow._LT_in_conditionalExpression1661); if (state.failed) return retval;

						}
						break;

					default:
						goto loop148;
					}
				}

				loop148:
					;

				} finally { DebugExitSubRule(148); }

				DebugLocation(264, 39);
				PushFollow(Follow._assignmentExpression_in_conditionalExpression1665);
				assignmentExpression308=assignmentExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression308.Tree);
				DebugLocation(264, 62);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:264:62: ( LT )*
				try { DebugEnterSubRule(149);
				while (true)
				{
					int alt149=2;
					try { DebugEnterDecision(149, decisionCanBacktrack[149]);
					int LA149_0 = input.LA(1);

					if ((LA149_0==LT))
					{
						alt149=1;
					}


					} finally { DebugExitDecision(149); }
					switch ( alt149 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(264, 62);
						LT309=(IToken)Match(input,LT,Follow._LT_in_conditionalExpression1667); if (state.failed) return retval;

						}
						break;

					default:
						goto loop149;
					}
				}

				loop149:
					;

				} finally { DebugExitSubRule(149); }

				DebugLocation(264, 65);
				char_literal310=(IToken)Match(input,50,Follow._50_in_conditionalExpression1671); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal310_tree = (object)adaptor.Create(char_literal310);
				adaptor.AddChild(root_0, char_literal310_tree);
				}
				DebugLocation(264, 71);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:264:71: ( LT )*
				try { DebugEnterSubRule(150);
				while (true)
				{
					int alt150=2;
					try { DebugEnterDecision(150, decisionCanBacktrack[150]);
					int LA150_0 = input.LA(1);

					if ((LA150_0==LT))
					{
						alt150=1;
					}


					} finally { DebugExitDecision(150); }
					switch ( alt150 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(264, 71);
						LT311=(IToken)Match(input,LT,Follow._LT_in_conditionalExpression1673); if (state.failed) return retval;

						}
						break;

					default:
						goto loop150;
					}
				}

				loop150:
					;

				} finally { DebugExitSubRule(150); }

				DebugLocation(264, 74);
				PushFollow(Follow._assignmentExpression_in_conditionalExpression1677);
				assignmentExpression312=assignmentExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression312.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(151); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("conditionalExpression", 55);
			LeaveRule("conditionalExpression", 55);
			Leave_conditionalExpression();
			if (state.backtracking > 0) { Memoize(input, 55, conditionalExpression_StartIndex); }
		}
		DebugLocation(265, 1);
		} finally { DebugExitRule(GrammarFileName, "conditionalExpression"); }
		return retval;

	}
	// $ANTLR end "conditionalExpression"

	public class conditionalExpressionNoIn_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_conditionalExpressionNoIn();
	partial void Leave_conditionalExpressionNoIn();

	// $ANTLR start "conditionalExpressionNoIn"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:267:1: conditionalExpressionNoIn : logicalORExpressionNoIn ( ( LT )* '?' ( LT )* assignmentExpressionNoIn ( LT )* ':' ( LT )* assignmentExpressionNoIn )? ;
	[GrammarRule("conditionalExpressionNoIn")]
	private JavaScriptParser.conditionalExpressionNoIn_return conditionalExpressionNoIn()
	{
		Enter_conditionalExpressionNoIn();
		EnterRule("conditionalExpressionNoIn", 56);
		TraceIn("conditionalExpressionNoIn", 56);
		JavaScriptParser.conditionalExpressionNoIn_return retval = new JavaScriptParser.conditionalExpressionNoIn_return();
		retval.Start = (IToken)input.LT(1);
		int conditionalExpressionNoIn_StartIndex = input.Index;
		object root_0 = null;

		IToken LT314=null;
		IToken char_literal315=null;
		IToken LT316=null;
		IToken LT318=null;
		IToken char_literal319=null;
		IToken LT320=null;
		JavaScriptParser.logicalORExpressionNoIn_return logicalORExpressionNoIn313 = default(JavaScriptParser.logicalORExpressionNoIn_return);
		JavaScriptParser.assignmentExpressionNoIn_return assignmentExpressionNoIn317 = default(JavaScriptParser.assignmentExpressionNoIn_return);
		JavaScriptParser.assignmentExpressionNoIn_return assignmentExpressionNoIn321 = default(JavaScriptParser.assignmentExpressionNoIn_return);

		object LT314_tree=null;
		object char_literal315_tree=null;
		object LT316_tree=null;
		object LT318_tree=null;
		object char_literal319_tree=null;
		object LT320_tree=null;

		try { DebugEnterRule(GrammarFileName, "conditionalExpressionNoIn");
		DebugLocation(267, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 56)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:268:2: ( logicalORExpressionNoIn ( ( LT )* '?' ( LT )* assignmentExpressionNoIn ( LT )* ':' ( LT )* assignmentExpressionNoIn )? )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:268:4: logicalORExpressionNoIn ( ( LT )* '?' ( LT )* assignmentExpressionNoIn ( LT )* ':' ( LT )* assignmentExpressionNoIn )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(268, 4);
			PushFollow(Follow._logicalORExpressionNoIn_in_conditionalExpressionNoIn1690);
			logicalORExpressionNoIn313=logicalORExpressionNoIn();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicalORExpressionNoIn313.Tree);
			DebugLocation(268, 28);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:268:28: ( ( LT )* '?' ( LT )* assignmentExpressionNoIn ( LT )* ':' ( LT )* assignmentExpressionNoIn )?
			int alt156=2;
			try { DebugEnterSubRule(156);
			try { DebugEnterDecision(156, decisionCanBacktrack[156]);
			try
			{
				alt156 = dfa156.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(156); }
			switch (alt156)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:268:29: ( LT )* '?' ( LT )* assignmentExpressionNoIn ( LT )* ':' ( LT )* assignmentExpressionNoIn
				{
				DebugLocation(268, 31);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:268:31: ( LT )*
				try { DebugEnterSubRule(152);
				while (true)
				{
					int alt152=2;
					try { DebugEnterDecision(152, decisionCanBacktrack[152]);
					int LA152_0 = input.LA(1);

					if ((LA152_0==LT))
					{
						alt152=1;
					}


					} finally { DebugExitDecision(152); }
					switch ( alt152 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(268, 31);
						LT314=(IToken)Match(input,LT,Follow._LT_in_conditionalExpressionNoIn1693); if (state.failed) return retval;

						}
						break;

					default:
						goto loop152;
					}
				}

				loop152:
					;

				} finally { DebugExitSubRule(152); }

				DebugLocation(268, 34);
				char_literal315=(IToken)Match(input,73,Follow._73_in_conditionalExpressionNoIn1697); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal315_tree = (object)adaptor.Create(char_literal315);
				adaptor.AddChild(root_0, char_literal315_tree);
				}
				DebugLocation(268, 40);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:268:40: ( LT )*
				try { DebugEnterSubRule(153);
				while (true)
				{
					int alt153=2;
					try { DebugEnterDecision(153, decisionCanBacktrack[153]);
					int LA153_0 = input.LA(1);

					if ((LA153_0==LT))
					{
						alt153=1;
					}


					} finally { DebugExitDecision(153); }
					switch ( alt153 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(268, 40);
						LT316=(IToken)Match(input,LT,Follow._LT_in_conditionalExpressionNoIn1699); if (state.failed) return retval;

						}
						break;

					default:
						goto loop153;
					}
				}

				loop153:
					;

				} finally { DebugExitSubRule(153); }

				DebugLocation(268, 43);
				PushFollow(Follow._assignmentExpressionNoIn_in_conditionalExpressionNoIn1703);
				assignmentExpressionNoIn317=assignmentExpressionNoIn();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpressionNoIn317.Tree);
				DebugLocation(268, 70);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:268:70: ( LT )*
				try { DebugEnterSubRule(154);
				while (true)
				{
					int alt154=2;
					try { DebugEnterDecision(154, decisionCanBacktrack[154]);
					int LA154_0 = input.LA(1);

					if ((LA154_0==LT))
					{
						alt154=1;
					}


					} finally { DebugExitDecision(154); }
					switch ( alt154 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(268, 70);
						LT318=(IToken)Match(input,LT,Follow._LT_in_conditionalExpressionNoIn1705); if (state.failed) return retval;

						}
						break;

					default:
						goto loop154;
					}
				}

				loop154:
					;

				} finally { DebugExitSubRule(154); }

				DebugLocation(268, 73);
				char_literal319=(IToken)Match(input,50,Follow._50_in_conditionalExpressionNoIn1709); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal319_tree = (object)adaptor.Create(char_literal319);
				adaptor.AddChild(root_0, char_literal319_tree);
				}
				DebugLocation(268, 79);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:268:79: ( LT )*
				try { DebugEnterSubRule(155);
				while (true)
				{
					int alt155=2;
					try { DebugEnterDecision(155, decisionCanBacktrack[155]);
					int LA155_0 = input.LA(1);

					if ((LA155_0==LT))
					{
						alt155=1;
					}


					} finally { DebugExitDecision(155); }
					switch ( alt155 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(268, 79);
						LT320=(IToken)Match(input,LT,Follow._LT_in_conditionalExpressionNoIn1711); if (state.failed) return retval;

						}
						break;

					default:
						goto loop155;
					}
				}

				loop155:
					;

				} finally { DebugExitSubRule(155); }

				DebugLocation(268, 82);
				PushFollow(Follow._assignmentExpressionNoIn_in_conditionalExpressionNoIn1715);
				assignmentExpressionNoIn321=assignmentExpressionNoIn();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpressionNoIn321.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(156); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("conditionalExpressionNoIn", 56);
			LeaveRule("conditionalExpressionNoIn", 56);
			Leave_conditionalExpressionNoIn();
			if (state.backtracking > 0) { Memoize(input, 56, conditionalExpressionNoIn_StartIndex); }
		}
		DebugLocation(269, 1);
		} finally { DebugExitRule(GrammarFileName, "conditionalExpressionNoIn"); }
		return retval;

	}
	// $ANTLR end "conditionalExpressionNoIn"

	public class logicalORExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_logicalORExpression();
	partial void Leave_logicalORExpression();

	// $ANTLR start "logicalORExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:271:1: logicalORExpression : logicalANDExpression ( ( LT )* '||' ( LT )* logicalANDExpression )* ;
	[GrammarRule("logicalORExpression")]
	private JavaScriptParser.logicalORExpression_return logicalORExpression()
	{
		Enter_logicalORExpression();
		EnterRule("logicalORExpression", 57);
		TraceIn("logicalORExpression", 57);
		JavaScriptParser.logicalORExpression_return retval = new JavaScriptParser.logicalORExpression_return();
		retval.Start = (IToken)input.LT(1);
		int logicalORExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken LT323=null;
		IToken string_literal324=null;
		IToken LT325=null;
		JavaScriptParser.logicalANDExpression_return logicalANDExpression322 = default(JavaScriptParser.logicalANDExpression_return);
		JavaScriptParser.logicalANDExpression_return logicalANDExpression326 = default(JavaScriptParser.logicalANDExpression_return);

		object LT323_tree=null;
		object string_literal324_tree=null;
		object LT325_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicalORExpression");
		DebugLocation(271, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 57)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:272:2: ( logicalANDExpression ( ( LT )* '||' ( LT )* logicalANDExpression )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:272:4: logicalANDExpression ( ( LT )* '||' ( LT )* logicalANDExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(272, 4);
			PushFollow(Follow._logicalANDExpression_in_logicalORExpression1728);
			logicalANDExpression322=logicalANDExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicalANDExpression322.Tree);
			DebugLocation(272, 25);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:272:25: ( ( LT )* '||' ( LT )* logicalANDExpression )*
			try { DebugEnterSubRule(159);
			while (true)
			{
				int alt159=2;
				try { DebugEnterDecision(159, decisionCanBacktrack[159]);
				try
				{
					alt159 = dfa159.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(159); }
				switch ( alt159 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:272:26: ( LT )* '||' ( LT )* logicalANDExpression
					{
					DebugLocation(272, 28);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:272:28: ( LT )*
					try { DebugEnterSubRule(157);
					while (true)
					{
						int alt157=2;
						try { DebugEnterDecision(157, decisionCanBacktrack[157]);
						int LA157_0 = input.LA(1);

						if ((LA157_0==LT))
						{
							alt157=1;
						}


						} finally { DebugExitDecision(157); }
						switch ( alt157 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(272, 28);
							LT323=(IToken)Match(input,LT,Follow._LT_in_logicalORExpression1731); if (state.failed) return retval;

							}
							break;

						default:
							goto loop157;
						}
					}

					loop157:
						;

					} finally { DebugExitSubRule(157); }

					DebugLocation(272, 31);
					string_literal324=(IToken)Match(input,74,Follow._74_in_logicalORExpression1735); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					string_literal324_tree = (object)adaptor.Create(string_literal324);
					adaptor.AddChild(root_0, string_literal324_tree);
					}
					DebugLocation(272, 38);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:272:38: ( LT )*
					try { DebugEnterSubRule(158);
					while (true)
					{
						int alt158=2;
						try { DebugEnterDecision(158, decisionCanBacktrack[158]);
						int LA158_0 = input.LA(1);

						if ((LA158_0==LT))
						{
							alt158=1;
						}


						} finally { DebugExitDecision(158); }
						switch ( alt158 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(272, 38);
							LT325=(IToken)Match(input,LT,Follow._LT_in_logicalORExpression1737); if (state.failed) return retval;

							}
							break;

						default:
							goto loop158;
						}
					}

					loop158:
						;

					} finally { DebugExitSubRule(158); }

					DebugLocation(272, 41);
					PushFollow(Follow._logicalANDExpression_in_logicalORExpression1741);
					logicalANDExpression326=logicalANDExpression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicalANDExpression326.Tree);

					}
					break;

				default:
					goto loop159;
				}
			}

			loop159:
				;

			} finally { DebugExitSubRule(159); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("logicalORExpression", 57);
			LeaveRule("logicalORExpression", 57);
			Leave_logicalORExpression();
			if (state.backtracking > 0) { Memoize(input, 57, logicalORExpression_StartIndex); }
		}
		DebugLocation(273, 1);
		} finally { DebugExitRule(GrammarFileName, "logicalORExpression"); }
		return retval;

	}
	// $ANTLR end "logicalORExpression"

	public class logicalORExpressionNoIn_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_logicalORExpressionNoIn();
	partial void Leave_logicalORExpressionNoIn();

	// $ANTLR start "logicalORExpressionNoIn"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:275:1: logicalORExpressionNoIn : logicalANDExpressionNoIn ( ( LT )* '||' ( LT )* logicalANDExpressionNoIn )* ;
	[GrammarRule("logicalORExpressionNoIn")]
	private JavaScriptParser.logicalORExpressionNoIn_return logicalORExpressionNoIn()
	{
		Enter_logicalORExpressionNoIn();
		EnterRule("logicalORExpressionNoIn", 58);
		TraceIn("logicalORExpressionNoIn", 58);
		JavaScriptParser.logicalORExpressionNoIn_return retval = new JavaScriptParser.logicalORExpressionNoIn_return();
		retval.Start = (IToken)input.LT(1);
		int logicalORExpressionNoIn_StartIndex = input.Index;
		object root_0 = null;

		IToken LT328=null;
		IToken string_literal329=null;
		IToken LT330=null;
		JavaScriptParser.logicalANDExpressionNoIn_return logicalANDExpressionNoIn327 = default(JavaScriptParser.logicalANDExpressionNoIn_return);
		JavaScriptParser.logicalANDExpressionNoIn_return logicalANDExpressionNoIn331 = default(JavaScriptParser.logicalANDExpressionNoIn_return);

		object LT328_tree=null;
		object string_literal329_tree=null;
		object LT330_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicalORExpressionNoIn");
		DebugLocation(275, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 58)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:276:2: ( logicalANDExpressionNoIn ( ( LT )* '||' ( LT )* logicalANDExpressionNoIn )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:276:4: logicalANDExpressionNoIn ( ( LT )* '||' ( LT )* logicalANDExpressionNoIn )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(276, 4);
			PushFollow(Follow._logicalANDExpressionNoIn_in_logicalORExpressionNoIn1755);
			logicalANDExpressionNoIn327=logicalANDExpressionNoIn();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicalANDExpressionNoIn327.Tree);
			DebugLocation(276, 29);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:276:29: ( ( LT )* '||' ( LT )* logicalANDExpressionNoIn )*
			try { DebugEnterSubRule(162);
			while (true)
			{
				int alt162=2;
				try { DebugEnterDecision(162, decisionCanBacktrack[162]);
				try
				{
					alt162 = dfa162.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(162); }
				switch ( alt162 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:276:30: ( LT )* '||' ( LT )* logicalANDExpressionNoIn
					{
					DebugLocation(276, 32);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:276:32: ( LT )*
					try { DebugEnterSubRule(160);
					while (true)
					{
						int alt160=2;
						try { DebugEnterDecision(160, decisionCanBacktrack[160]);
						int LA160_0 = input.LA(1);

						if ((LA160_0==LT))
						{
							alt160=1;
						}


						} finally { DebugExitDecision(160); }
						switch ( alt160 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(276, 32);
							LT328=(IToken)Match(input,LT,Follow._LT_in_logicalORExpressionNoIn1758); if (state.failed) return retval;

							}
							break;

						default:
							goto loop160;
						}
					}

					loop160:
						;

					} finally { DebugExitSubRule(160); }

					DebugLocation(276, 35);
					string_literal329=(IToken)Match(input,74,Follow._74_in_logicalORExpressionNoIn1762); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					string_literal329_tree = (object)adaptor.Create(string_literal329);
					adaptor.AddChild(root_0, string_literal329_tree);
					}
					DebugLocation(276, 42);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:276:42: ( LT )*
					try { DebugEnterSubRule(161);
					while (true)
					{
						int alt161=2;
						try { DebugEnterDecision(161, decisionCanBacktrack[161]);
						int LA161_0 = input.LA(1);

						if ((LA161_0==LT))
						{
							alt161=1;
						}


						} finally { DebugExitDecision(161); }
						switch ( alt161 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(276, 42);
							LT330=(IToken)Match(input,LT,Follow._LT_in_logicalORExpressionNoIn1764); if (state.failed) return retval;

							}
							break;

						default:
							goto loop161;
						}
					}

					loop161:
						;

					} finally { DebugExitSubRule(161); }

					DebugLocation(276, 45);
					PushFollow(Follow._logicalANDExpressionNoIn_in_logicalORExpressionNoIn1768);
					logicalANDExpressionNoIn331=logicalANDExpressionNoIn();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicalANDExpressionNoIn331.Tree);

					}
					break;

				default:
					goto loop162;
				}
			}

			loop162:
				;

			} finally { DebugExitSubRule(162); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("logicalORExpressionNoIn", 58);
			LeaveRule("logicalORExpressionNoIn", 58);
			Leave_logicalORExpressionNoIn();
			if (state.backtracking > 0) { Memoize(input, 58, logicalORExpressionNoIn_StartIndex); }
		}
		DebugLocation(277, 1);
		} finally { DebugExitRule(GrammarFileName, "logicalORExpressionNoIn"); }
		return retval;

	}
	// $ANTLR end "logicalORExpressionNoIn"

	public class logicalANDExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_logicalANDExpression();
	partial void Leave_logicalANDExpression();

	// $ANTLR start "logicalANDExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:279:1: logicalANDExpression : bitwiseORExpression ( ( LT )* '&&' ( LT )* bitwiseORExpression )* ;
	[GrammarRule("logicalANDExpression")]
	private JavaScriptParser.logicalANDExpression_return logicalANDExpression()
	{
		Enter_logicalANDExpression();
		EnterRule("logicalANDExpression", 59);
		TraceIn("logicalANDExpression", 59);
		JavaScriptParser.logicalANDExpression_return retval = new JavaScriptParser.logicalANDExpression_return();
		retval.Start = (IToken)input.LT(1);
		int logicalANDExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken LT333=null;
		IToken string_literal334=null;
		IToken LT335=null;
		JavaScriptParser.bitwiseORExpression_return bitwiseORExpression332 = default(JavaScriptParser.bitwiseORExpression_return);
		JavaScriptParser.bitwiseORExpression_return bitwiseORExpression336 = default(JavaScriptParser.bitwiseORExpression_return);

		object LT333_tree=null;
		object string_literal334_tree=null;
		object LT335_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicalANDExpression");
		DebugLocation(279, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 59)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:280:2: ( bitwiseORExpression ( ( LT )* '&&' ( LT )* bitwiseORExpression )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:280:4: bitwiseORExpression ( ( LT )* '&&' ( LT )* bitwiseORExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(280, 4);
			PushFollow(Follow._bitwiseORExpression_in_logicalANDExpression1782);
			bitwiseORExpression332=bitwiseORExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseORExpression332.Tree);
			DebugLocation(280, 24);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:280:24: ( ( LT )* '&&' ( LT )* bitwiseORExpression )*
			try { DebugEnterSubRule(165);
			while (true)
			{
				int alt165=2;
				try { DebugEnterDecision(165, decisionCanBacktrack[165]);
				try
				{
					alt165 = dfa165.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(165); }
				switch ( alt165 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:280:25: ( LT )* '&&' ( LT )* bitwiseORExpression
					{
					DebugLocation(280, 27);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:280:27: ( LT )*
					try { DebugEnterSubRule(163);
					while (true)
					{
						int alt163=2;
						try { DebugEnterDecision(163, decisionCanBacktrack[163]);
						int LA163_0 = input.LA(1);

						if ((LA163_0==LT))
						{
							alt163=1;
						}


						} finally { DebugExitDecision(163); }
						switch ( alt163 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(280, 27);
							LT333=(IToken)Match(input,LT,Follow._LT_in_logicalANDExpression1785); if (state.failed) return retval;

							}
							break;

						default:
							goto loop163;
						}
					}

					loop163:
						;

					} finally { DebugExitSubRule(163); }

					DebugLocation(280, 30);
					string_literal334=(IToken)Match(input,75,Follow._75_in_logicalANDExpression1789); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					string_literal334_tree = (object)adaptor.Create(string_literal334);
					adaptor.AddChild(root_0, string_literal334_tree);
					}
					DebugLocation(280, 37);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:280:37: ( LT )*
					try { DebugEnterSubRule(164);
					while (true)
					{
						int alt164=2;
						try { DebugEnterDecision(164, decisionCanBacktrack[164]);
						int LA164_0 = input.LA(1);

						if ((LA164_0==LT))
						{
							alt164=1;
						}


						} finally { DebugExitDecision(164); }
						switch ( alt164 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(280, 37);
							LT335=(IToken)Match(input,LT,Follow._LT_in_logicalANDExpression1791); if (state.failed) return retval;

							}
							break;

						default:
							goto loop164;
						}
					}

					loop164:
						;

					} finally { DebugExitSubRule(164); }

					DebugLocation(280, 40);
					PushFollow(Follow._bitwiseORExpression_in_logicalANDExpression1795);
					bitwiseORExpression336=bitwiseORExpression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseORExpression336.Tree);

					}
					break;

				default:
					goto loop165;
				}
			}

			loop165:
				;

			} finally { DebugExitSubRule(165); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("logicalANDExpression", 59);
			LeaveRule("logicalANDExpression", 59);
			Leave_logicalANDExpression();
			if (state.backtracking > 0) { Memoize(input, 59, logicalANDExpression_StartIndex); }
		}
		DebugLocation(281, 1);
		} finally { DebugExitRule(GrammarFileName, "logicalANDExpression"); }
		return retval;

	}
	// $ANTLR end "logicalANDExpression"

	public class logicalANDExpressionNoIn_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_logicalANDExpressionNoIn();
	partial void Leave_logicalANDExpressionNoIn();

	// $ANTLR start "logicalANDExpressionNoIn"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:283:1: logicalANDExpressionNoIn : bitwiseORExpressionNoIn ( ( LT )* '&&' ( LT )* bitwiseORExpressionNoIn )* ;
	[GrammarRule("logicalANDExpressionNoIn")]
	private JavaScriptParser.logicalANDExpressionNoIn_return logicalANDExpressionNoIn()
	{
		Enter_logicalANDExpressionNoIn();
		EnterRule("logicalANDExpressionNoIn", 60);
		TraceIn("logicalANDExpressionNoIn", 60);
		JavaScriptParser.logicalANDExpressionNoIn_return retval = new JavaScriptParser.logicalANDExpressionNoIn_return();
		retval.Start = (IToken)input.LT(1);
		int logicalANDExpressionNoIn_StartIndex = input.Index;
		object root_0 = null;

		IToken LT338=null;
		IToken string_literal339=null;
		IToken LT340=null;
		JavaScriptParser.bitwiseORExpressionNoIn_return bitwiseORExpressionNoIn337 = default(JavaScriptParser.bitwiseORExpressionNoIn_return);
		JavaScriptParser.bitwiseORExpressionNoIn_return bitwiseORExpressionNoIn341 = default(JavaScriptParser.bitwiseORExpressionNoIn_return);

		object LT338_tree=null;
		object string_literal339_tree=null;
		object LT340_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicalANDExpressionNoIn");
		DebugLocation(283, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 60)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:284:2: ( bitwiseORExpressionNoIn ( ( LT )* '&&' ( LT )* bitwiseORExpressionNoIn )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:284:4: bitwiseORExpressionNoIn ( ( LT )* '&&' ( LT )* bitwiseORExpressionNoIn )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(284, 4);
			PushFollow(Follow._bitwiseORExpressionNoIn_in_logicalANDExpressionNoIn1809);
			bitwiseORExpressionNoIn337=bitwiseORExpressionNoIn();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseORExpressionNoIn337.Tree);
			DebugLocation(284, 28);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:284:28: ( ( LT )* '&&' ( LT )* bitwiseORExpressionNoIn )*
			try { DebugEnterSubRule(168);
			while (true)
			{
				int alt168=2;
				try { DebugEnterDecision(168, decisionCanBacktrack[168]);
				try
				{
					alt168 = dfa168.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(168); }
				switch ( alt168 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:284:29: ( LT )* '&&' ( LT )* bitwiseORExpressionNoIn
					{
					DebugLocation(284, 31);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:284:31: ( LT )*
					try { DebugEnterSubRule(166);
					while (true)
					{
						int alt166=2;
						try { DebugEnterDecision(166, decisionCanBacktrack[166]);
						int LA166_0 = input.LA(1);

						if ((LA166_0==LT))
						{
							alt166=1;
						}


						} finally { DebugExitDecision(166); }
						switch ( alt166 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(284, 31);
							LT338=(IToken)Match(input,LT,Follow._LT_in_logicalANDExpressionNoIn1812); if (state.failed) return retval;

							}
							break;

						default:
							goto loop166;
						}
					}

					loop166:
						;

					} finally { DebugExitSubRule(166); }

					DebugLocation(284, 34);
					string_literal339=(IToken)Match(input,75,Follow._75_in_logicalANDExpressionNoIn1816); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					string_literal339_tree = (object)adaptor.Create(string_literal339);
					adaptor.AddChild(root_0, string_literal339_tree);
					}
					DebugLocation(284, 41);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:284:41: ( LT )*
					try { DebugEnterSubRule(167);
					while (true)
					{
						int alt167=2;
						try { DebugEnterDecision(167, decisionCanBacktrack[167]);
						int LA167_0 = input.LA(1);

						if ((LA167_0==LT))
						{
							alt167=1;
						}


						} finally { DebugExitDecision(167); }
						switch ( alt167 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(284, 41);
							LT340=(IToken)Match(input,LT,Follow._LT_in_logicalANDExpressionNoIn1818); if (state.failed) return retval;

							}
							break;

						default:
							goto loop167;
						}
					}

					loop167:
						;

					} finally { DebugExitSubRule(167); }

					DebugLocation(284, 44);
					PushFollow(Follow._bitwiseORExpressionNoIn_in_logicalANDExpressionNoIn1822);
					bitwiseORExpressionNoIn341=bitwiseORExpressionNoIn();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseORExpressionNoIn341.Tree);

					}
					break;

				default:
					goto loop168;
				}
			}

			loop168:
				;

			} finally { DebugExitSubRule(168); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("logicalANDExpressionNoIn", 60);
			LeaveRule("logicalANDExpressionNoIn", 60);
			Leave_logicalANDExpressionNoIn();
			if (state.backtracking > 0) { Memoize(input, 60, logicalANDExpressionNoIn_StartIndex); }
		}
		DebugLocation(285, 1);
		} finally { DebugExitRule(GrammarFileName, "logicalANDExpressionNoIn"); }
		return retval;

	}
	// $ANTLR end "logicalANDExpressionNoIn"

	public class bitwiseORExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bitwiseORExpression();
	partial void Leave_bitwiseORExpression();

	// $ANTLR start "bitwiseORExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:287:1: bitwiseORExpression : bitwiseXORExpression ( ( LT )* '|' ( LT )* bitwiseXORExpression )* ;
	[GrammarRule("bitwiseORExpression")]
	private JavaScriptParser.bitwiseORExpression_return bitwiseORExpression()
	{
		Enter_bitwiseORExpression();
		EnterRule("bitwiseORExpression", 61);
		TraceIn("bitwiseORExpression", 61);
		JavaScriptParser.bitwiseORExpression_return retval = new JavaScriptParser.bitwiseORExpression_return();
		retval.Start = (IToken)input.LT(1);
		int bitwiseORExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken LT343=null;
		IToken char_literal344=null;
		IToken LT345=null;
		JavaScriptParser.bitwiseXORExpression_return bitwiseXORExpression342 = default(JavaScriptParser.bitwiseXORExpression_return);
		JavaScriptParser.bitwiseXORExpression_return bitwiseXORExpression346 = default(JavaScriptParser.bitwiseXORExpression_return);

		object LT343_tree=null;
		object char_literal344_tree=null;
		object LT345_tree=null;

		try { DebugEnterRule(GrammarFileName, "bitwiseORExpression");
		DebugLocation(287, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 61)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:288:2: ( bitwiseXORExpression ( ( LT )* '|' ( LT )* bitwiseXORExpression )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:288:4: bitwiseXORExpression ( ( LT )* '|' ( LT )* bitwiseXORExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(288, 4);
			PushFollow(Follow._bitwiseXORExpression_in_bitwiseORExpression1836);
			bitwiseXORExpression342=bitwiseXORExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseXORExpression342.Tree);
			DebugLocation(288, 25);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:288:25: ( ( LT )* '|' ( LT )* bitwiseXORExpression )*
			try { DebugEnterSubRule(171);
			while (true)
			{
				int alt171=2;
				try { DebugEnterDecision(171, decisionCanBacktrack[171]);
				try
				{
					alt171 = dfa171.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(171); }
				switch ( alt171 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:288:26: ( LT )* '|' ( LT )* bitwiseXORExpression
					{
					DebugLocation(288, 28);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:288:28: ( LT )*
					try { DebugEnterSubRule(169);
					while (true)
					{
						int alt169=2;
						try { DebugEnterDecision(169, decisionCanBacktrack[169]);
						int LA169_0 = input.LA(1);

						if ((LA169_0==LT))
						{
							alt169=1;
						}


						} finally { DebugExitDecision(169); }
						switch ( alt169 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(288, 28);
							LT343=(IToken)Match(input,LT,Follow._LT_in_bitwiseORExpression1839); if (state.failed) return retval;

							}
							break;

						default:
							goto loop169;
						}
					}

					loop169:
						;

					} finally { DebugExitSubRule(169); }

					DebugLocation(288, 31);
					char_literal344=(IToken)Match(input,76,Follow._76_in_bitwiseORExpression1843); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					char_literal344_tree = (object)adaptor.Create(char_literal344);
					adaptor.AddChild(root_0, char_literal344_tree);
					}
					DebugLocation(288, 37);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:288:37: ( LT )*
					try { DebugEnterSubRule(170);
					while (true)
					{
						int alt170=2;
						try { DebugEnterDecision(170, decisionCanBacktrack[170]);
						int LA170_0 = input.LA(1);

						if ((LA170_0==LT))
						{
							alt170=1;
						}


						} finally { DebugExitDecision(170); }
						switch ( alt170 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(288, 37);
							LT345=(IToken)Match(input,LT,Follow._LT_in_bitwiseORExpression1845); if (state.failed) return retval;

							}
							break;

						default:
							goto loop170;
						}
					}

					loop170:
						;

					} finally { DebugExitSubRule(170); }

					DebugLocation(288, 40);
					PushFollow(Follow._bitwiseXORExpression_in_bitwiseORExpression1849);
					bitwiseXORExpression346=bitwiseXORExpression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseXORExpression346.Tree);

					}
					break;

				default:
					goto loop171;
				}
			}

			loop171:
				;

			} finally { DebugExitSubRule(171); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bitwiseORExpression", 61);
			LeaveRule("bitwiseORExpression", 61);
			Leave_bitwiseORExpression();
			if (state.backtracking > 0) { Memoize(input, 61, bitwiseORExpression_StartIndex); }
		}
		DebugLocation(289, 1);
		} finally { DebugExitRule(GrammarFileName, "bitwiseORExpression"); }
		return retval;

	}
	// $ANTLR end "bitwiseORExpression"

	public class bitwiseORExpressionNoIn_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bitwiseORExpressionNoIn();
	partial void Leave_bitwiseORExpressionNoIn();

	// $ANTLR start "bitwiseORExpressionNoIn"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:291:1: bitwiseORExpressionNoIn : bitwiseXORExpressionNoIn ( ( LT )* '|' ( LT )* bitwiseXORExpressionNoIn )* ;
	[GrammarRule("bitwiseORExpressionNoIn")]
	private JavaScriptParser.bitwiseORExpressionNoIn_return bitwiseORExpressionNoIn()
	{
		Enter_bitwiseORExpressionNoIn();
		EnterRule("bitwiseORExpressionNoIn", 62);
		TraceIn("bitwiseORExpressionNoIn", 62);
		JavaScriptParser.bitwiseORExpressionNoIn_return retval = new JavaScriptParser.bitwiseORExpressionNoIn_return();
		retval.Start = (IToken)input.LT(1);
		int bitwiseORExpressionNoIn_StartIndex = input.Index;
		object root_0 = null;

		IToken LT348=null;
		IToken char_literal349=null;
		IToken LT350=null;
		JavaScriptParser.bitwiseXORExpressionNoIn_return bitwiseXORExpressionNoIn347 = default(JavaScriptParser.bitwiseXORExpressionNoIn_return);
		JavaScriptParser.bitwiseXORExpressionNoIn_return bitwiseXORExpressionNoIn351 = default(JavaScriptParser.bitwiseXORExpressionNoIn_return);

		object LT348_tree=null;
		object char_literal349_tree=null;
		object LT350_tree=null;

		try { DebugEnterRule(GrammarFileName, "bitwiseORExpressionNoIn");
		DebugLocation(291, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 62)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:292:2: ( bitwiseXORExpressionNoIn ( ( LT )* '|' ( LT )* bitwiseXORExpressionNoIn )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:292:4: bitwiseXORExpressionNoIn ( ( LT )* '|' ( LT )* bitwiseXORExpressionNoIn )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(292, 4);
			PushFollow(Follow._bitwiseXORExpressionNoIn_in_bitwiseORExpressionNoIn1863);
			bitwiseXORExpressionNoIn347=bitwiseXORExpressionNoIn();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseXORExpressionNoIn347.Tree);
			DebugLocation(292, 29);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:292:29: ( ( LT )* '|' ( LT )* bitwiseXORExpressionNoIn )*
			try { DebugEnterSubRule(174);
			while (true)
			{
				int alt174=2;
				try { DebugEnterDecision(174, decisionCanBacktrack[174]);
				try
				{
					alt174 = dfa174.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(174); }
				switch ( alt174 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:292:30: ( LT )* '|' ( LT )* bitwiseXORExpressionNoIn
					{
					DebugLocation(292, 32);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:292:32: ( LT )*
					try { DebugEnterSubRule(172);
					while (true)
					{
						int alt172=2;
						try { DebugEnterDecision(172, decisionCanBacktrack[172]);
						int LA172_0 = input.LA(1);

						if ((LA172_0==LT))
						{
							alt172=1;
						}


						} finally { DebugExitDecision(172); }
						switch ( alt172 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(292, 32);
							LT348=(IToken)Match(input,LT,Follow._LT_in_bitwiseORExpressionNoIn1866); if (state.failed) return retval;

							}
							break;

						default:
							goto loop172;
						}
					}

					loop172:
						;

					} finally { DebugExitSubRule(172); }

					DebugLocation(292, 35);
					char_literal349=(IToken)Match(input,76,Follow._76_in_bitwiseORExpressionNoIn1870); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					char_literal349_tree = (object)adaptor.Create(char_literal349);
					adaptor.AddChild(root_0, char_literal349_tree);
					}
					DebugLocation(292, 41);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:292:41: ( LT )*
					try { DebugEnterSubRule(173);
					while (true)
					{
						int alt173=2;
						try { DebugEnterDecision(173, decisionCanBacktrack[173]);
						int LA173_0 = input.LA(1);

						if ((LA173_0==LT))
						{
							alt173=1;
						}


						} finally { DebugExitDecision(173); }
						switch ( alt173 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(292, 41);
							LT350=(IToken)Match(input,LT,Follow._LT_in_bitwiseORExpressionNoIn1872); if (state.failed) return retval;

							}
							break;

						default:
							goto loop173;
						}
					}

					loop173:
						;

					} finally { DebugExitSubRule(173); }

					DebugLocation(292, 44);
					PushFollow(Follow._bitwiseXORExpressionNoIn_in_bitwiseORExpressionNoIn1876);
					bitwiseXORExpressionNoIn351=bitwiseXORExpressionNoIn();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseXORExpressionNoIn351.Tree);

					}
					break;

				default:
					goto loop174;
				}
			}

			loop174:
				;

			} finally { DebugExitSubRule(174); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bitwiseORExpressionNoIn", 62);
			LeaveRule("bitwiseORExpressionNoIn", 62);
			Leave_bitwiseORExpressionNoIn();
			if (state.backtracking > 0) { Memoize(input, 62, bitwiseORExpressionNoIn_StartIndex); }
		}
		DebugLocation(293, 1);
		} finally { DebugExitRule(GrammarFileName, "bitwiseORExpressionNoIn"); }
		return retval;

	}
	// $ANTLR end "bitwiseORExpressionNoIn"

	public class bitwiseXORExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bitwiseXORExpression();
	partial void Leave_bitwiseXORExpression();

	// $ANTLR start "bitwiseXORExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:295:1: bitwiseXORExpression : bitwiseANDExpression ( ( LT )* '^' ( LT )* bitwiseANDExpression )* ;
	[GrammarRule("bitwiseXORExpression")]
	private JavaScriptParser.bitwiseXORExpression_return bitwiseXORExpression()
	{
		Enter_bitwiseXORExpression();
		EnterRule("bitwiseXORExpression", 63);
		TraceIn("bitwiseXORExpression", 63);
		JavaScriptParser.bitwiseXORExpression_return retval = new JavaScriptParser.bitwiseXORExpression_return();
		retval.Start = (IToken)input.LT(1);
		int bitwiseXORExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken LT353=null;
		IToken char_literal354=null;
		IToken LT355=null;
		JavaScriptParser.bitwiseANDExpression_return bitwiseANDExpression352 = default(JavaScriptParser.bitwiseANDExpression_return);
		JavaScriptParser.bitwiseANDExpression_return bitwiseANDExpression356 = default(JavaScriptParser.bitwiseANDExpression_return);

		object LT353_tree=null;
		object char_literal354_tree=null;
		object LT355_tree=null;

		try { DebugEnterRule(GrammarFileName, "bitwiseXORExpression");
		DebugLocation(295, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 63)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:296:2: ( bitwiseANDExpression ( ( LT )* '^' ( LT )* bitwiseANDExpression )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:296:4: bitwiseANDExpression ( ( LT )* '^' ( LT )* bitwiseANDExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(296, 4);
			PushFollow(Follow._bitwiseANDExpression_in_bitwiseXORExpression1890);
			bitwiseANDExpression352=bitwiseANDExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseANDExpression352.Tree);
			DebugLocation(296, 25);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:296:25: ( ( LT )* '^' ( LT )* bitwiseANDExpression )*
			try { DebugEnterSubRule(177);
			while (true)
			{
				int alt177=2;
				try { DebugEnterDecision(177, decisionCanBacktrack[177]);
				try
				{
					alt177 = dfa177.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(177); }
				switch ( alt177 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:296:26: ( LT )* '^' ( LT )* bitwiseANDExpression
					{
					DebugLocation(296, 28);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:296:28: ( LT )*
					try { DebugEnterSubRule(175);
					while (true)
					{
						int alt175=2;
						try { DebugEnterDecision(175, decisionCanBacktrack[175]);
						int LA175_0 = input.LA(1);

						if ((LA175_0==LT))
						{
							alt175=1;
						}


						} finally { DebugExitDecision(175); }
						switch ( alt175 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(296, 28);
							LT353=(IToken)Match(input,LT,Follow._LT_in_bitwiseXORExpression1893); if (state.failed) return retval;

							}
							break;

						default:
							goto loop175;
						}
					}

					loop175:
						;

					} finally { DebugExitSubRule(175); }

					DebugLocation(296, 31);
					char_literal354=(IToken)Match(input,77,Follow._77_in_bitwiseXORExpression1897); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					char_literal354_tree = (object)adaptor.Create(char_literal354);
					adaptor.AddChild(root_0, char_literal354_tree);
					}
					DebugLocation(296, 37);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:296:37: ( LT )*
					try { DebugEnterSubRule(176);
					while (true)
					{
						int alt176=2;
						try { DebugEnterDecision(176, decisionCanBacktrack[176]);
						int LA176_0 = input.LA(1);

						if ((LA176_0==LT))
						{
							alt176=1;
						}


						} finally { DebugExitDecision(176); }
						switch ( alt176 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(296, 37);
							LT355=(IToken)Match(input,LT,Follow._LT_in_bitwiseXORExpression1899); if (state.failed) return retval;

							}
							break;

						default:
							goto loop176;
						}
					}

					loop176:
						;

					} finally { DebugExitSubRule(176); }

					DebugLocation(296, 40);
					PushFollow(Follow._bitwiseANDExpression_in_bitwiseXORExpression1903);
					bitwiseANDExpression356=bitwiseANDExpression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseANDExpression356.Tree);

					}
					break;

				default:
					goto loop177;
				}
			}

			loop177:
				;

			} finally { DebugExitSubRule(177); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bitwiseXORExpression", 63);
			LeaveRule("bitwiseXORExpression", 63);
			Leave_bitwiseXORExpression();
			if (state.backtracking > 0) { Memoize(input, 63, bitwiseXORExpression_StartIndex); }
		}
		DebugLocation(297, 1);
		} finally { DebugExitRule(GrammarFileName, "bitwiseXORExpression"); }
		return retval;

	}
	// $ANTLR end "bitwiseXORExpression"

	public class bitwiseXORExpressionNoIn_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bitwiseXORExpressionNoIn();
	partial void Leave_bitwiseXORExpressionNoIn();

	// $ANTLR start "bitwiseXORExpressionNoIn"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:299:1: bitwiseXORExpressionNoIn : bitwiseANDExpressionNoIn ( ( LT )* '^' ( LT )* bitwiseANDExpressionNoIn )* ;
	[GrammarRule("bitwiseXORExpressionNoIn")]
	private JavaScriptParser.bitwiseXORExpressionNoIn_return bitwiseXORExpressionNoIn()
	{
		Enter_bitwiseXORExpressionNoIn();
		EnterRule("bitwiseXORExpressionNoIn", 64);
		TraceIn("bitwiseXORExpressionNoIn", 64);
		JavaScriptParser.bitwiseXORExpressionNoIn_return retval = new JavaScriptParser.bitwiseXORExpressionNoIn_return();
		retval.Start = (IToken)input.LT(1);
		int bitwiseXORExpressionNoIn_StartIndex = input.Index;
		object root_0 = null;

		IToken LT358=null;
		IToken char_literal359=null;
		IToken LT360=null;
		JavaScriptParser.bitwiseANDExpressionNoIn_return bitwiseANDExpressionNoIn357 = default(JavaScriptParser.bitwiseANDExpressionNoIn_return);
		JavaScriptParser.bitwiseANDExpressionNoIn_return bitwiseANDExpressionNoIn361 = default(JavaScriptParser.bitwiseANDExpressionNoIn_return);

		object LT358_tree=null;
		object char_literal359_tree=null;
		object LT360_tree=null;

		try { DebugEnterRule(GrammarFileName, "bitwiseXORExpressionNoIn");
		DebugLocation(299, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 64)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:300:2: ( bitwiseANDExpressionNoIn ( ( LT )* '^' ( LT )* bitwiseANDExpressionNoIn )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:300:4: bitwiseANDExpressionNoIn ( ( LT )* '^' ( LT )* bitwiseANDExpressionNoIn )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(300, 4);
			PushFollow(Follow._bitwiseANDExpressionNoIn_in_bitwiseXORExpressionNoIn1917);
			bitwiseANDExpressionNoIn357=bitwiseANDExpressionNoIn();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseANDExpressionNoIn357.Tree);
			DebugLocation(300, 29);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:300:29: ( ( LT )* '^' ( LT )* bitwiseANDExpressionNoIn )*
			try { DebugEnterSubRule(180);
			while (true)
			{
				int alt180=2;
				try { DebugEnterDecision(180, decisionCanBacktrack[180]);
				try
				{
					alt180 = dfa180.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(180); }
				switch ( alt180 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:300:30: ( LT )* '^' ( LT )* bitwiseANDExpressionNoIn
					{
					DebugLocation(300, 32);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:300:32: ( LT )*
					try { DebugEnterSubRule(178);
					while (true)
					{
						int alt178=2;
						try { DebugEnterDecision(178, decisionCanBacktrack[178]);
						int LA178_0 = input.LA(1);

						if ((LA178_0==LT))
						{
							alt178=1;
						}


						} finally { DebugExitDecision(178); }
						switch ( alt178 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(300, 32);
							LT358=(IToken)Match(input,LT,Follow._LT_in_bitwiseXORExpressionNoIn1920); if (state.failed) return retval;

							}
							break;

						default:
							goto loop178;
						}
					}

					loop178:
						;

					} finally { DebugExitSubRule(178); }

					DebugLocation(300, 35);
					char_literal359=(IToken)Match(input,77,Follow._77_in_bitwiseXORExpressionNoIn1924); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					char_literal359_tree = (object)adaptor.Create(char_literal359);
					adaptor.AddChild(root_0, char_literal359_tree);
					}
					DebugLocation(300, 41);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:300:41: ( LT )*
					try { DebugEnterSubRule(179);
					while (true)
					{
						int alt179=2;
						try { DebugEnterDecision(179, decisionCanBacktrack[179]);
						int LA179_0 = input.LA(1);

						if ((LA179_0==LT))
						{
							alt179=1;
						}


						} finally { DebugExitDecision(179); }
						switch ( alt179 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(300, 41);
							LT360=(IToken)Match(input,LT,Follow._LT_in_bitwiseXORExpressionNoIn1926); if (state.failed) return retval;

							}
							break;

						default:
							goto loop179;
						}
					}

					loop179:
						;

					} finally { DebugExitSubRule(179); }

					DebugLocation(300, 44);
					PushFollow(Follow._bitwiseANDExpressionNoIn_in_bitwiseXORExpressionNoIn1930);
					bitwiseANDExpressionNoIn361=bitwiseANDExpressionNoIn();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseANDExpressionNoIn361.Tree);

					}
					break;

				default:
					goto loop180;
				}
			}

			loop180:
				;

			} finally { DebugExitSubRule(180); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bitwiseXORExpressionNoIn", 64);
			LeaveRule("bitwiseXORExpressionNoIn", 64);
			Leave_bitwiseXORExpressionNoIn();
			if (state.backtracking > 0) { Memoize(input, 64, bitwiseXORExpressionNoIn_StartIndex); }
		}
		DebugLocation(301, 1);
		} finally { DebugExitRule(GrammarFileName, "bitwiseXORExpressionNoIn"); }
		return retval;

	}
	// $ANTLR end "bitwiseXORExpressionNoIn"

	public class bitwiseANDExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bitwiseANDExpression();
	partial void Leave_bitwiseANDExpression();

	// $ANTLR start "bitwiseANDExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:303:1: bitwiseANDExpression : equalityExpression ( ( LT )* '&' ( LT )* equalityExpression )* ;
	[GrammarRule("bitwiseANDExpression")]
	private JavaScriptParser.bitwiseANDExpression_return bitwiseANDExpression()
	{
		Enter_bitwiseANDExpression();
		EnterRule("bitwiseANDExpression", 65);
		TraceIn("bitwiseANDExpression", 65);
		JavaScriptParser.bitwiseANDExpression_return retval = new JavaScriptParser.bitwiseANDExpression_return();
		retval.Start = (IToken)input.LT(1);
		int bitwiseANDExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken LT363=null;
		IToken char_literal364=null;
		IToken LT365=null;
		JavaScriptParser.equalityExpression_return equalityExpression362 = default(JavaScriptParser.equalityExpression_return);
		JavaScriptParser.equalityExpression_return equalityExpression366 = default(JavaScriptParser.equalityExpression_return);

		object LT363_tree=null;
		object char_literal364_tree=null;
		object LT365_tree=null;

		try { DebugEnterRule(GrammarFileName, "bitwiseANDExpression");
		DebugLocation(303, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 65)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:304:2: ( equalityExpression ( ( LT )* '&' ( LT )* equalityExpression )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:304:4: equalityExpression ( ( LT )* '&' ( LT )* equalityExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(304, 4);
			PushFollow(Follow._equalityExpression_in_bitwiseANDExpression1944);
			equalityExpression362=equalityExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression362.Tree);
			DebugLocation(304, 23);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:304:23: ( ( LT )* '&' ( LT )* equalityExpression )*
			try { DebugEnterSubRule(183);
			while (true)
			{
				int alt183=2;
				try { DebugEnterDecision(183, decisionCanBacktrack[183]);
				try
				{
					alt183 = dfa183.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(183); }
				switch ( alt183 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:304:24: ( LT )* '&' ( LT )* equalityExpression
					{
					DebugLocation(304, 26);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:304:26: ( LT )*
					try { DebugEnterSubRule(181);
					while (true)
					{
						int alt181=2;
						try { DebugEnterDecision(181, decisionCanBacktrack[181]);
						int LA181_0 = input.LA(1);

						if ((LA181_0==LT))
						{
							alt181=1;
						}


						} finally { DebugExitDecision(181); }
						switch ( alt181 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(304, 26);
							LT363=(IToken)Match(input,LT,Follow._LT_in_bitwiseANDExpression1947); if (state.failed) return retval;

							}
							break;

						default:
							goto loop181;
						}
					}

					loop181:
						;

					} finally { DebugExitSubRule(181); }

					DebugLocation(304, 29);
					char_literal364=(IToken)Match(input,78,Follow._78_in_bitwiseANDExpression1951); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					char_literal364_tree = (object)adaptor.Create(char_literal364);
					adaptor.AddChild(root_0, char_literal364_tree);
					}
					DebugLocation(304, 35);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:304:35: ( LT )*
					try { DebugEnterSubRule(182);
					while (true)
					{
						int alt182=2;
						try { DebugEnterDecision(182, decisionCanBacktrack[182]);
						int LA182_0 = input.LA(1);

						if ((LA182_0==LT))
						{
							alt182=1;
						}


						} finally { DebugExitDecision(182); }
						switch ( alt182 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(304, 35);
							LT365=(IToken)Match(input,LT,Follow._LT_in_bitwiseANDExpression1953); if (state.failed) return retval;

							}
							break;

						default:
							goto loop182;
						}
					}

					loop182:
						;

					} finally { DebugExitSubRule(182); }

					DebugLocation(304, 38);
					PushFollow(Follow._equalityExpression_in_bitwiseANDExpression1957);
					equalityExpression366=equalityExpression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression366.Tree);

					}
					break;

				default:
					goto loop183;
				}
			}

			loop183:
				;

			} finally { DebugExitSubRule(183); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bitwiseANDExpression", 65);
			LeaveRule("bitwiseANDExpression", 65);
			Leave_bitwiseANDExpression();
			if (state.backtracking > 0) { Memoize(input, 65, bitwiseANDExpression_StartIndex); }
		}
		DebugLocation(305, 1);
		} finally { DebugExitRule(GrammarFileName, "bitwiseANDExpression"); }
		return retval;

	}
	// $ANTLR end "bitwiseANDExpression"

	public class bitwiseANDExpressionNoIn_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bitwiseANDExpressionNoIn();
	partial void Leave_bitwiseANDExpressionNoIn();

	// $ANTLR start "bitwiseANDExpressionNoIn"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:307:1: bitwiseANDExpressionNoIn : equalityExpressionNoIn ( ( LT )* '&' ( LT )* equalityExpressionNoIn )* ;
	[GrammarRule("bitwiseANDExpressionNoIn")]
	private JavaScriptParser.bitwiseANDExpressionNoIn_return bitwiseANDExpressionNoIn()
	{
		Enter_bitwiseANDExpressionNoIn();
		EnterRule("bitwiseANDExpressionNoIn", 66);
		TraceIn("bitwiseANDExpressionNoIn", 66);
		JavaScriptParser.bitwiseANDExpressionNoIn_return retval = new JavaScriptParser.bitwiseANDExpressionNoIn_return();
		retval.Start = (IToken)input.LT(1);
		int bitwiseANDExpressionNoIn_StartIndex = input.Index;
		object root_0 = null;

		IToken LT368=null;
		IToken char_literal369=null;
		IToken LT370=null;
		JavaScriptParser.equalityExpressionNoIn_return equalityExpressionNoIn367 = default(JavaScriptParser.equalityExpressionNoIn_return);
		JavaScriptParser.equalityExpressionNoIn_return equalityExpressionNoIn371 = default(JavaScriptParser.equalityExpressionNoIn_return);

		object LT368_tree=null;
		object char_literal369_tree=null;
		object LT370_tree=null;

		try { DebugEnterRule(GrammarFileName, "bitwiseANDExpressionNoIn");
		DebugLocation(307, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 66)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:308:2: ( equalityExpressionNoIn ( ( LT )* '&' ( LT )* equalityExpressionNoIn )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:308:4: equalityExpressionNoIn ( ( LT )* '&' ( LT )* equalityExpressionNoIn )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(308, 4);
			PushFollow(Follow._equalityExpressionNoIn_in_bitwiseANDExpressionNoIn1971);
			equalityExpressionNoIn367=equalityExpressionNoIn();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpressionNoIn367.Tree);
			DebugLocation(308, 27);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:308:27: ( ( LT )* '&' ( LT )* equalityExpressionNoIn )*
			try { DebugEnterSubRule(186);
			while (true)
			{
				int alt186=2;
				try { DebugEnterDecision(186, decisionCanBacktrack[186]);
				try
				{
					alt186 = dfa186.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(186); }
				switch ( alt186 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:308:28: ( LT )* '&' ( LT )* equalityExpressionNoIn
					{
					DebugLocation(308, 30);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:308:30: ( LT )*
					try { DebugEnterSubRule(184);
					while (true)
					{
						int alt184=2;
						try { DebugEnterDecision(184, decisionCanBacktrack[184]);
						int LA184_0 = input.LA(1);

						if ((LA184_0==LT))
						{
							alt184=1;
						}


						} finally { DebugExitDecision(184); }
						switch ( alt184 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(308, 30);
							LT368=(IToken)Match(input,LT,Follow._LT_in_bitwiseANDExpressionNoIn1974); if (state.failed) return retval;

							}
							break;

						default:
							goto loop184;
						}
					}

					loop184:
						;

					} finally { DebugExitSubRule(184); }

					DebugLocation(308, 33);
					char_literal369=(IToken)Match(input,78,Follow._78_in_bitwiseANDExpressionNoIn1978); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					char_literal369_tree = (object)adaptor.Create(char_literal369);
					adaptor.AddChild(root_0, char_literal369_tree);
					}
					DebugLocation(308, 39);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:308:39: ( LT )*
					try { DebugEnterSubRule(185);
					while (true)
					{
						int alt185=2;
						try { DebugEnterDecision(185, decisionCanBacktrack[185]);
						int LA185_0 = input.LA(1);

						if ((LA185_0==LT))
						{
							alt185=1;
						}


						} finally { DebugExitDecision(185); }
						switch ( alt185 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(308, 39);
							LT370=(IToken)Match(input,LT,Follow._LT_in_bitwiseANDExpressionNoIn1980); if (state.failed) return retval;

							}
							break;

						default:
							goto loop185;
						}
					}

					loop185:
						;

					} finally { DebugExitSubRule(185); }

					DebugLocation(308, 42);
					PushFollow(Follow._equalityExpressionNoIn_in_bitwiseANDExpressionNoIn1984);
					equalityExpressionNoIn371=equalityExpressionNoIn();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpressionNoIn371.Tree);

					}
					break;

				default:
					goto loop186;
				}
			}

			loop186:
				;

			} finally { DebugExitSubRule(186); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bitwiseANDExpressionNoIn", 66);
			LeaveRule("bitwiseANDExpressionNoIn", 66);
			Leave_bitwiseANDExpressionNoIn();
			if (state.backtracking > 0) { Memoize(input, 66, bitwiseANDExpressionNoIn_StartIndex); }
		}
		DebugLocation(309, 1);
		} finally { DebugExitRule(GrammarFileName, "bitwiseANDExpressionNoIn"); }
		return retval;

	}
	// $ANTLR end "bitwiseANDExpressionNoIn"

	public class equalityExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_equalityExpression();
	partial void Leave_equalityExpression();

	// $ANTLR start "equalityExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:311:1: equalityExpression : relationalExpression ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpression )* ;
	[GrammarRule("equalityExpression")]
	private JavaScriptParser.equalityExpression_return equalityExpression()
	{
		Enter_equalityExpression();
		EnterRule("equalityExpression", 67);
		TraceIn("equalityExpression", 67);
		JavaScriptParser.equalityExpression_return retval = new JavaScriptParser.equalityExpression_return();
		retval.Start = (IToken)input.LT(1);
		int equalityExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken LT373=null;
		IToken set374=null;
		IToken LT375=null;
		JavaScriptParser.relationalExpression_return relationalExpression372 = default(JavaScriptParser.relationalExpression_return);
		JavaScriptParser.relationalExpression_return relationalExpression376 = default(JavaScriptParser.relationalExpression_return);

		object LT373_tree=null;
		object set374_tree=null;
		object LT375_tree=null;

		try { DebugEnterRule(GrammarFileName, "equalityExpression");
		DebugLocation(311, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 67)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:312:2: ( relationalExpression ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpression )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:312:4: relationalExpression ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(312, 4);
			PushFollow(Follow._relationalExpression_in_equalityExpression1998);
			relationalExpression372=relationalExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression372.Tree);
			DebugLocation(312, 25);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:312:25: ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpression )*
			try { DebugEnterSubRule(189);
			while (true)
			{
				int alt189=2;
				try { DebugEnterDecision(189, decisionCanBacktrack[189]);
				try
				{
					alt189 = dfa189.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(189); }
				switch ( alt189 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:312:26: ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpression
					{
					DebugLocation(312, 28);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:312:28: ( LT )*
					try { DebugEnterSubRule(187);
					while (true)
					{
						int alt187=2;
						try { DebugEnterDecision(187, decisionCanBacktrack[187]);
						int LA187_0 = input.LA(1);

						if ((LA187_0==LT))
						{
							alt187=1;
						}


						} finally { DebugExitDecision(187); }
						switch ( alt187 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(312, 28);
							LT373=(IToken)Match(input,LT,Follow._LT_in_equalityExpression2001); if (state.failed) return retval;

							}
							break;

						default:
							goto loop187;
						}
					}

					loop187:
						;

					} finally { DebugExitSubRule(187); }

					DebugLocation(312, 31);
					set374=(IToken)input.LT(1);
					if ((input.LA(1)>=79 && input.LA(1)<=82))
					{
						input.Consume();
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set374));
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(312, 63);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:312:63: ( LT )*
					try { DebugEnterSubRule(188);
					while (true)
					{
						int alt188=2;
						try { DebugEnterDecision(188, decisionCanBacktrack[188]);
						int LA188_0 = input.LA(1);

						if ((LA188_0==LT))
						{
							alt188=1;
						}


						} finally { DebugExitDecision(188); }
						switch ( alt188 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(312, 63);
							LT375=(IToken)Match(input,LT,Follow._LT_in_equalityExpression2021); if (state.failed) return retval;

							}
							break;

						default:
							goto loop188;
						}
					}

					loop188:
						;

					} finally { DebugExitSubRule(188); }

					DebugLocation(312, 66);
					PushFollow(Follow._relationalExpression_in_equalityExpression2025);
					relationalExpression376=relationalExpression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression376.Tree);

					}
					break;

				default:
					goto loop189;
				}
			}

			loop189:
				;

			} finally { DebugExitSubRule(189); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("equalityExpression", 67);
			LeaveRule("equalityExpression", 67);
			Leave_equalityExpression();
			if (state.backtracking > 0) { Memoize(input, 67, equalityExpression_StartIndex); }
		}
		DebugLocation(313, 1);
		} finally { DebugExitRule(GrammarFileName, "equalityExpression"); }
		return retval;

	}
	// $ANTLR end "equalityExpression"

	public class equalityExpressionNoIn_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_equalityExpressionNoIn();
	partial void Leave_equalityExpressionNoIn();

	// $ANTLR start "equalityExpressionNoIn"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:315:1: equalityExpressionNoIn : relationalExpressionNoIn ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpressionNoIn )* ;
	[GrammarRule("equalityExpressionNoIn")]
	private JavaScriptParser.equalityExpressionNoIn_return equalityExpressionNoIn()
	{
		Enter_equalityExpressionNoIn();
		EnterRule("equalityExpressionNoIn", 68);
		TraceIn("equalityExpressionNoIn", 68);
		JavaScriptParser.equalityExpressionNoIn_return retval = new JavaScriptParser.equalityExpressionNoIn_return();
		retval.Start = (IToken)input.LT(1);
		int equalityExpressionNoIn_StartIndex = input.Index;
		object root_0 = null;

		IToken LT378=null;
		IToken set379=null;
		IToken LT380=null;
		JavaScriptParser.relationalExpressionNoIn_return relationalExpressionNoIn377 = default(JavaScriptParser.relationalExpressionNoIn_return);
		JavaScriptParser.relationalExpressionNoIn_return relationalExpressionNoIn381 = default(JavaScriptParser.relationalExpressionNoIn_return);

		object LT378_tree=null;
		object set379_tree=null;
		object LT380_tree=null;

		try { DebugEnterRule(GrammarFileName, "equalityExpressionNoIn");
		DebugLocation(315, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 68)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:316:2: ( relationalExpressionNoIn ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpressionNoIn )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:316:4: relationalExpressionNoIn ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpressionNoIn )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(316, 4);
			PushFollow(Follow._relationalExpressionNoIn_in_equalityExpressionNoIn2038);
			relationalExpressionNoIn377=relationalExpressionNoIn();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpressionNoIn377.Tree);
			DebugLocation(316, 29);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:316:29: ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpressionNoIn )*
			try { DebugEnterSubRule(192);
			while (true)
			{
				int alt192=2;
				try { DebugEnterDecision(192, decisionCanBacktrack[192]);
				try
				{
					alt192 = dfa192.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(192); }
				switch ( alt192 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:316:30: ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpressionNoIn
					{
					DebugLocation(316, 32);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:316:32: ( LT )*
					try { DebugEnterSubRule(190);
					while (true)
					{
						int alt190=2;
						try { DebugEnterDecision(190, decisionCanBacktrack[190]);
						int LA190_0 = input.LA(1);

						if ((LA190_0==LT))
						{
							alt190=1;
						}


						} finally { DebugExitDecision(190); }
						switch ( alt190 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(316, 32);
							LT378=(IToken)Match(input,LT,Follow._LT_in_equalityExpressionNoIn2041); if (state.failed) return retval;

							}
							break;

						default:
							goto loop190;
						}
					}

					loop190:
						;

					} finally { DebugExitSubRule(190); }

					DebugLocation(316, 35);
					set379=(IToken)input.LT(1);
					if ((input.LA(1)>=79 && input.LA(1)<=82))
					{
						input.Consume();
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set379));
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(316, 67);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:316:67: ( LT )*
					try { DebugEnterSubRule(191);
					while (true)
					{
						int alt191=2;
						try { DebugEnterDecision(191, decisionCanBacktrack[191]);
						int LA191_0 = input.LA(1);

						if ((LA191_0==LT))
						{
							alt191=1;
						}


						} finally { DebugExitDecision(191); }
						switch ( alt191 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(316, 67);
							LT380=(IToken)Match(input,LT,Follow._LT_in_equalityExpressionNoIn2061); if (state.failed) return retval;

							}
							break;

						default:
							goto loop191;
						}
					}

					loop191:
						;

					} finally { DebugExitSubRule(191); }

					DebugLocation(316, 70);
					PushFollow(Follow._relationalExpressionNoIn_in_equalityExpressionNoIn2065);
					relationalExpressionNoIn381=relationalExpressionNoIn();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpressionNoIn381.Tree);

					}
					break;

				default:
					goto loop192;
				}
			}

			loop192:
				;

			} finally { DebugExitSubRule(192); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("equalityExpressionNoIn", 68);
			LeaveRule("equalityExpressionNoIn", 68);
			Leave_equalityExpressionNoIn();
			if (state.backtracking > 0) { Memoize(input, 68, equalityExpressionNoIn_StartIndex); }
		}
		DebugLocation(317, 1);
		} finally { DebugExitRule(GrammarFileName, "equalityExpressionNoIn"); }
		return retval;

	}
	// $ANTLR end "equalityExpressionNoIn"

	public class relationalExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_relationalExpression();
	partial void Leave_relationalExpression();

	// $ANTLR start "relationalExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:319:1: relationalExpression : shiftExpression ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' | 'in' ) ( LT )* shiftExpression )* ;
	[GrammarRule("relationalExpression")]
	private JavaScriptParser.relationalExpression_return relationalExpression()
	{
		Enter_relationalExpression();
		EnterRule("relationalExpression", 69);
		TraceIn("relationalExpression", 69);
		JavaScriptParser.relationalExpression_return retval = new JavaScriptParser.relationalExpression_return();
		retval.Start = (IToken)input.LT(1);
		int relationalExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken LT383=null;
		IToken set384=null;
		IToken LT385=null;
		JavaScriptParser.shiftExpression_return shiftExpression382 = default(JavaScriptParser.shiftExpression_return);
		JavaScriptParser.shiftExpression_return shiftExpression386 = default(JavaScriptParser.shiftExpression_return);

		object LT383_tree=null;
		object set384_tree=null;
		object LT385_tree=null;

		try { DebugEnterRule(GrammarFileName, "relationalExpression");
		DebugLocation(319, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 69)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:320:2: ( shiftExpression ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' | 'in' ) ( LT )* shiftExpression )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:320:4: shiftExpression ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' | 'in' ) ( LT )* shiftExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(320, 4);
			PushFollow(Follow._shiftExpression_in_relationalExpression2079);
			shiftExpression382=shiftExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, shiftExpression382.Tree);
			DebugLocation(320, 20);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:320:20: ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' | 'in' ) ( LT )* shiftExpression )*
			try { DebugEnterSubRule(195);
			while (true)
			{
				int alt195=2;
				try { DebugEnterDecision(195, decisionCanBacktrack[195]);
				try
				{
					alt195 = dfa195.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(195); }
				switch ( alt195 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:320:21: ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' | 'in' ) ( LT )* shiftExpression
					{
					DebugLocation(320, 23);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:320:23: ( LT )*
					try { DebugEnterSubRule(193);
					while (true)
					{
						int alt193=2;
						try { DebugEnterDecision(193, decisionCanBacktrack[193]);
						int LA193_0 = input.LA(1);

						if ((LA193_0==LT))
						{
							alt193=1;
						}


						} finally { DebugExitDecision(193); }
						switch ( alt193 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(320, 23);
							LT383=(IToken)Match(input,LT,Follow._LT_in_relationalExpression2082); if (state.failed) return retval;

							}
							break;

						default:
							goto loop193;
						}
					}

					loop193:
						;

					} finally { DebugExitSubRule(193); }

					DebugLocation(320, 26);
					set384=(IToken)input.LT(1);
					if (input.LA(1)==45||(input.LA(1)>=83 && input.LA(1)<=87))
					{
						input.Consume();
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set384));
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(320, 76);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:320:76: ( LT )*
					try { DebugEnterSubRule(194);
					while (true)
					{
						int alt194=2;
						try { DebugEnterDecision(194, decisionCanBacktrack[194]);
						int LA194_0 = input.LA(1);

						if ((LA194_0==LT))
						{
							alt194=1;
						}


						} finally { DebugExitDecision(194); }
						switch ( alt194 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(320, 76);
							LT385=(IToken)Match(input,LT,Follow._LT_in_relationalExpression2110); if (state.failed) return retval;

							}
							break;

						default:
							goto loop194;
						}
					}

					loop194:
						;

					} finally { DebugExitSubRule(194); }

					DebugLocation(320, 79);
					PushFollow(Follow._shiftExpression_in_relationalExpression2114);
					shiftExpression386=shiftExpression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, shiftExpression386.Tree);

					}
					break;

				default:
					goto loop195;
				}
			}

			loop195:
				;

			} finally { DebugExitSubRule(195); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("relationalExpression", 69);
			LeaveRule("relationalExpression", 69);
			Leave_relationalExpression();
			if (state.backtracking > 0) { Memoize(input, 69, relationalExpression_StartIndex); }
		}
		DebugLocation(321, 1);
		} finally { DebugExitRule(GrammarFileName, "relationalExpression"); }
		return retval;

	}
	// $ANTLR end "relationalExpression"

	public class relationalExpressionNoIn_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_relationalExpressionNoIn();
	partial void Leave_relationalExpressionNoIn();

	// $ANTLR start "relationalExpressionNoIn"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:323:1: relationalExpressionNoIn : shiftExpression ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' ) ( LT )* shiftExpression )* ;
	[GrammarRule("relationalExpressionNoIn")]
	private JavaScriptParser.relationalExpressionNoIn_return relationalExpressionNoIn()
	{
		Enter_relationalExpressionNoIn();
		EnterRule("relationalExpressionNoIn", 70);
		TraceIn("relationalExpressionNoIn", 70);
		JavaScriptParser.relationalExpressionNoIn_return retval = new JavaScriptParser.relationalExpressionNoIn_return();
		retval.Start = (IToken)input.LT(1);
		int relationalExpressionNoIn_StartIndex = input.Index;
		object root_0 = null;

		IToken LT388=null;
		IToken set389=null;
		IToken LT390=null;
		JavaScriptParser.shiftExpression_return shiftExpression387 = default(JavaScriptParser.shiftExpression_return);
		JavaScriptParser.shiftExpression_return shiftExpression391 = default(JavaScriptParser.shiftExpression_return);

		object LT388_tree=null;
		object set389_tree=null;
		object LT390_tree=null;

		try { DebugEnterRule(GrammarFileName, "relationalExpressionNoIn");
		DebugLocation(323, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 70)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:324:2: ( shiftExpression ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' ) ( LT )* shiftExpression )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:324:4: shiftExpression ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' ) ( LT )* shiftExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(324, 4);
			PushFollow(Follow._shiftExpression_in_relationalExpressionNoIn2127);
			shiftExpression387=shiftExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, shiftExpression387.Tree);
			DebugLocation(324, 20);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:324:20: ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' ) ( LT )* shiftExpression )*
			try { DebugEnterSubRule(198);
			while (true)
			{
				int alt198=2;
				try { DebugEnterDecision(198, decisionCanBacktrack[198]);
				try
				{
					alt198 = dfa198.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(198); }
				switch ( alt198 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:324:21: ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' ) ( LT )* shiftExpression
					{
					DebugLocation(324, 23);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:324:23: ( LT )*
					try { DebugEnterSubRule(196);
					while (true)
					{
						int alt196=2;
						try { DebugEnterDecision(196, decisionCanBacktrack[196]);
						int LA196_0 = input.LA(1);

						if ((LA196_0==LT))
						{
							alt196=1;
						}


						} finally { DebugExitDecision(196); }
						switch ( alt196 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(324, 23);
							LT388=(IToken)Match(input,LT,Follow._LT_in_relationalExpressionNoIn2130); if (state.failed) return retval;

							}
							break;

						default:
							goto loop196;
						}
					}

					loop196:
						;

					} finally { DebugExitSubRule(196); }

					DebugLocation(324, 26);
					set389=(IToken)input.LT(1);
					if ((input.LA(1)>=83 && input.LA(1)<=87))
					{
						input.Consume();
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set389));
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(324, 69);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:324:69: ( LT )*
					try { DebugEnterSubRule(197);
					while (true)
					{
						int alt197=2;
						try { DebugEnterDecision(197, decisionCanBacktrack[197]);
						int LA197_0 = input.LA(1);

						if ((LA197_0==LT))
						{
							alt197=1;
						}


						} finally { DebugExitDecision(197); }
						switch ( alt197 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(324, 69);
							LT390=(IToken)Match(input,LT,Follow._LT_in_relationalExpressionNoIn2154); if (state.failed) return retval;

							}
							break;

						default:
							goto loop197;
						}
					}

					loop197:
						;

					} finally { DebugExitSubRule(197); }

					DebugLocation(324, 72);
					PushFollow(Follow._shiftExpression_in_relationalExpressionNoIn2158);
					shiftExpression391=shiftExpression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, shiftExpression391.Tree);

					}
					break;

				default:
					goto loop198;
				}
			}

			loop198:
				;

			} finally { DebugExitSubRule(198); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("relationalExpressionNoIn", 70);
			LeaveRule("relationalExpressionNoIn", 70);
			Leave_relationalExpressionNoIn();
			if (state.backtracking > 0) { Memoize(input, 70, relationalExpressionNoIn_StartIndex); }
		}
		DebugLocation(325, 1);
		} finally { DebugExitRule(GrammarFileName, "relationalExpressionNoIn"); }
		return retval;

	}
	// $ANTLR end "relationalExpressionNoIn"

	public class shiftExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_shiftExpression();
	partial void Leave_shiftExpression();

	// $ANTLR start "shiftExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:327:1: shiftExpression : additiveExpression ( ( LT )* ( '<<' | '>>' | '>>>' ) ( LT )* additiveExpression )* ;
	[GrammarRule("shiftExpression")]
	private JavaScriptParser.shiftExpression_return shiftExpression()
	{
		Enter_shiftExpression();
		EnterRule("shiftExpression", 71);
		TraceIn("shiftExpression", 71);
		JavaScriptParser.shiftExpression_return retval = new JavaScriptParser.shiftExpression_return();
		retval.Start = (IToken)input.LT(1);
		int shiftExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken LT393=null;
		IToken set394=null;
		IToken LT395=null;
		JavaScriptParser.additiveExpression_return additiveExpression392 = default(JavaScriptParser.additiveExpression_return);
		JavaScriptParser.additiveExpression_return additiveExpression396 = default(JavaScriptParser.additiveExpression_return);

		object LT393_tree=null;
		object set394_tree=null;
		object LT395_tree=null;

		try { DebugEnterRule(GrammarFileName, "shiftExpression");
		DebugLocation(327, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 71)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:328:2: ( additiveExpression ( ( LT )* ( '<<' | '>>' | '>>>' ) ( LT )* additiveExpression )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:328:4: additiveExpression ( ( LT )* ( '<<' | '>>' | '>>>' ) ( LT )* additiveExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(328, 4);
			PushFollow(Follow._additiveExpression_in_shiftExpression2171);
			additiveExpression392=additiveExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression392.Tree);
			DebugLocation(328, 23);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:328:23: ( ( LT )* ( '<<' | '>>' | '>>>' ) ( LT )* additiveExpression )*
			try { DebugEnterSubRule(201);
			while (true)
			{
				int alt201=2;
				try { DebugEnterDecision(201, decisionCanBacktrack[201]);
				try
				{
					alt201 = dfa201.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(201); }
				switch ( alt201 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:328:24: ( LT )* ( '<<' | '>>' | '>>>' ) ( LT )* additiveExpression
					{
					DebugLocation(328, 26);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:328:26: ( LT )*
					try { DebugEnterSubRule(199);
					while (true)
					{
						int alt199=2;
						try { DebugEnterDecision(199, decisionCanBacktrack[199]);
						int LA199_0 = input.LA(1);

						if ((LA199_0==LT))
						{
							alt199=1;
						}


						} finally { DebugExitDecision(199); }
						switch ( alt199 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(328, 26);
							LT393=(IToken)Match(input,LT,Follow._LT_in_shiftExpression2174); if (state.failed) return retval;

							}
							break;

						default:
							goto loop199;
						}
					}

					loop199:
						;

					} finally { DebugExitSubRule(199); }

					DebugLocation(328, 29);
					set394=(IToken)input.LT(1);
					if ((input.LA(1)>=88 && input.LA(1)<=90))
					{
						input.Consume();
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set394));
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(328, 53);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:328:53: ( LT )*
					try { DebugEnterSubRule(200);
					while (true)
					{
						int alt200=2;
						try { DebugEnterDecision(200, decisionCanBacktrack[200]);
						int LA200_0 = input.LA(1);

						if ((LA200_0==LT))
						{
							alt200=1;
						}


						} finally { DebugExitDecision(200); }
						switch ( alt200 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(328, 53);
							LT395=(IToken)Match(input,LT,Follow._LT_in_shiftExpression2190); if (state.failed) return retval;

							}
							break;

						default:
							goto loop200;
						}
					}

					loop200:
						;

					} finally { DebugExitSubRule(200); }

					DebugLocation(328, 56);
					PushFollow(Follow._additiveExpression_in_shiftExpression2194);
					additiveExpression396=additiveExpression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression396.Tree);

					}
					break;

				default:
					goto loop201;
				}
			}

			loop201:
				;

			} finally { DebugExitSubRule(201); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("shiftExpression", 71);
			LeaveRule("shiftExpression", 71);
			Leave_shiftExpression();
			if (state.backtracking > 0) { Memoize(input, 71, shiftExpression_StartIndex); }
		}
		DebugLocation(329, 1);
		} finally { DebugExitRule(GrammarFileName, "shiftExpression"); }
		return retval;

	}
	// $ANTLR end "shiftExpression"

	public class additiveExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_additiveExpression();
	partial void Leave_additiveExpression();

	// $ANTLR start "additiveExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:331:1: additiveExpression : multiplicativeExpression ( ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression )* ;
	[GrammarRule("additiveExpression")]
	private JavaScriptParser.additiveExpression_return additiveExpression()
	{
		Enter_additiveExpression();
		EnterRule("additiveExpression", 72);
		TraceIn("additiveExpression", 72);
		JavaScriptParser.additiveExpression_return retval = new JavaScriptParser.additiveExpression_return();
		retval.Start = (IToken)input.LT(1);
		int additiveExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken LT398=null;
		IToken set399=null;
		IToken LT400=null;
		JavaScriptParser.multiplicativeExpression_return multiplicativeExpression397 = default(JavaScriptParser.multiplicativeExpression_return);
		JavaScriptParser.multiplicativeExpression_return multiplicativeExpression401 = default(JavaScriptParser.multiplicativeExpression_return);

		object LT398_tree=null;
		object set399_tree=null;
		object LT400_tree=null;

		try { DebugEnterRule(GrammarFileName, "additiveExpression");
		DebugLocation(331, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 72)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:332:2: ( multiplicativeExpression ( ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:332:4: multiplicativeExpression ( ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(332, 4);
			PushFollow(Follow._multiplicativeExpression_in_additiveExpression2207);
			multiplicativeExpression397=multiplicativeExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression397.Tree);
			DebugLocation(332, 29);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:332:29: ( ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression )*
			try { DebugEnterSubRule(204);
			while (true)
			{
				int alt204=2;
				try { DebugEnterDecision(204, decisionCanBacktrack[204]);
				try
				{
					alt204 = dfa204.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(204); }
				switch ( alt204 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:332:30: ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression
					{
					DebugLocation(332, 32);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:332:32: ( LT )*
					try { DebugEnterSubRule(202);
					while (true)
					{
						int alt202=2;
						try { DebugEnterDecision(202, decisionCanBacktrack[202]);
						int LA202_0 = input.LA(1);

						if ((LA202_0==LT))
						{
							alt202=1;
						}


						} finally { DebugExitDecision(202); }
						switch ( alt202 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(332, 32);
							LT398=(IToken)Match(input,LT,Follow._LT_in_additiveExpression2210); if (state.failed) return retval;

							}
							break;

						default:
							goto loop202;
						}
					}

					loop202:
						;

					} finally { DebugExitSubRule(202); }

					DebugLocation(332, 35);
					set399=(IToken)input.LT(1);
					if ((input.LA(1)>=91 && input.LA(1)<=92))
					{
						input.Consume();
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set399));
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(332, 49);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:332:49: ( LT )*
					try { DebugEnterSubRule(203);
					while (true)
					{
						int alt203=2;
						try { DebugEnterDecision(203, decisionCanBacktrack[203]);
						int LA203_0 = input.LA(1);

						if ((LA203_0==LT))
						{
							alt203=1;
						}


						} finally { DebugExitDecision(203); }
						switch ( alt203 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(332, 49);
							LT400=(IToken)Match(input,LT,Follow._LT_in_additiveExpression2222); if (state.failed) return retval;

							}
							break;

						default:
							goto loop203;
						}
					}

					loop203:
						;

					} finally { DebugExitSubRule(203); }

					DebugLocation(332, 52);
					PushFollow(Follow._multiplicativeExpression_in_additiveExpression2226);
					multiplicativeExpression401=multiplicativeExpression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression401.Tree);

					}
					break;

				default:
					goto loop204;
				}
			}

			loop204:
				;

			} finally { DebugExitSubRule(204); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("additiveExpression", 72);
			LeaveRule("additiveExpression", 72);
			Leave_additiveExpression();
			if (state.backtracking > 0) { Memoize(input, 72, additiveExpression_StartIndex); }
		}
		DebugLocation(333, 1);
		} finally { DebugExitRule(GrammarFileName, "additiveExpression"); }
		return retval;

	}
	// $ANTLR end "additiveExpression"

	public class multiplicativeExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_multiplicativeExpression();
	partial void Leave_multiplicativeExpression();

	// $ANTLR start "multiplicativeExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:335:1: multiplicativeExpression : unaryExpression ( ( LT )* ( '*' | '/' | '%' ) ( LT )* unaryExpression )* ;
	[GrammarRule("multiplicativeExpression")]
	private JavaScriptParser.multiplicativeExpression_return multiplicativeExpression()
	{
		Enter_multiplicativeExpression();
		EnterRule("multiplicativeExpression", 73);
		TraceIn("multiplicativeExpression", 73);
		JavaScriptParser.multiplicativeExpression_return retval = new JavaScriptParser.multiplicativeExpression_return();
		retval.Start = (IToken)input.LT(1);
		int multiplicativeExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken LT403=null;
		IToken set404=null;
		IToken LT405=null;
		JavaScriptParser.unaryExpression_return unaryExpression402 = default(JavaScriptParser.unaryExpression_return);
		JavaScriptParser.unaryExpression_return unaryExpression406 = default(JavaScriptParser.unaryExpression_return);

		object LT403_tree=null;
		object set404_tree=null;
		object LT405_tree=null;

		try { DebugEnterRule(GrammarFileName, "multiplicativeExpression");
		DebugLocation(335, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 73)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:336:2: ( unaryExpression ( ( LT )* ( '*' | '/' | '%' ) ( LT )* unaryExpression )* )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:336:4: unaryExpression ( ( LT )* ( '*' | '/' | '%' ) ( LT )* unaryExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(336, 4);
			PushFollow(Follow._unaryExpression_in_multiplicativeExpression2239);
			unaryExpression402=unaryExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression402.Tree);
			DebugLocation(336, 20);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:336:20: ( ( LT )* ( '*' | '/' | '%' ) ( LT )* unaryExpression )*
			try { DebugEnterSubRule(207);
			while (true)
			{
				int alt207=2;
				try { DebugEnterDecision(207, decisionCanBacktrack[207]);
				try
				{
					alt207 = dfa207.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(207); }
				switch ( alt207 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:336:21: ( LT )* ( '*' | '/' | '%' ) ( LT )* unaryExpression
					{
					DebugLocation(336, 23);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:336:23: ( LT )*
					try { DebugEnterSubRule(205);
					while (true)
					{
						int alt205=2;
						try { DebugEnterDecision(205, decisionCanBacktrack[205]);
						int LA205_0 = input.LA(1);

						if ((LA205_0==LT))
						{
							alt205=1;
						}


						} finally { DebugExitDecision(205); }
						switch ( alt205 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(336, 23);
							LT403=(IToken)Match(input,LT,Follow._LT_in_multiplicativeExpression2242); if (state.failed) return retval;

							}
							break;

						default:
							goto loop205;
						}
					}

					loop205:
						;

					} finally { DebugExitSubRule(205); }

					DebugLocation(336, 26);
					set404=(IToken)input.LT(1);
					if ((input.LA(1)>=93 && input.LA(1)<=95))
					{
						input.Consume();
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set404));
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(336, 46);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:336:46: ( LT )*
					try { DebugEnterSubRule(206);
					while (true)
					{
						int alt206=2;
						try { DebugEnterDecision(206, decisionCanBacktrack[206]);
						int LA206_0 = input.LA(1);

						if ((LA206_0==LT))
						{
							alt206=1;
						}


						} finally { DebugExitDecision(206); }
						switch ( alt206 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(336, 46);
							LT405=(IToken)Match(input,LT,Follow._LT_in_multiplicativeExpression2258); if (state.failed) return retval;

							}
							break;

						default:
							goto loop206;
						}
					}

					loop206:
						;

					} finally { DebugExitSubRule(206); }

					DebugLocation(336, 49);
					PushFollow(Follow._unaryExpression_in_multiplicativeExpression2262);
					unaryExpression406=unaryExpression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression406.Tree);

					}
					break;

				default:
					goto loop207;
				}
			}

			loop207:
				;

			} finally { DebugExitSubRule(207); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("multiplicativeExpression", 73);
			LeaveRule("multiplicativeExpression", 73);
			Leave_multiplicativeExpression();
			if (state.backtracking > 0) { Memoize(input, 73, multiplicativeExpression_StartIndex); }
		}
		DebugLocation(337, 1);
		} finally { DebugExitRule(GrammarFileName, "multiplicativeExpression"); }
		return retval;

	}
	// $ANTLR end "multiplicativeExpression"

	public class unaryExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_unaryExpression();
	partial void Leave_unaryExpression();

	// $ANTLR start "unaryExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:339:1: unaryExpression : ( postfixExpression | ( 'delete' | 'void' | 'typeof' | '++' | '--' | '+' | '-' | '~' | '!' ) unaryExpression );
	[GrammarRule("unaryExpression")]
	private JavaScriptParser.unaryExpression_return unaryExpression()
	{
		Enter_unaryExpression();
		EnterRule("unaryExpression", 74);
		TraceIn("unaryExpression", 74);
		JavaScriptParser.unaryExpression_return retval = new JavaScriptParser.unaryExpression_return();
		retval.Start = (IToken)input.LT(1);
		int unaryExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken set408=null;
		JavaScriptParser.postfixExpression_return postfixExpression407 = default(JavaScriptParser.postfixExpression_return);
		JavaScriptParser.unaryExpression_return unaryExpression409 = default(JavaScriptParser.unaryExpression_return);

		object set408_tree=null;

		try { DebugEnterRule(GrammarFileName, "unaryExpression");
		DebugLocation(339, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 74)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:340:2: ( postfixExpression | ( 'delete' | 'void' | 'typeof' | '++' | '--' | '+' | '-' | '~' | '!' ) unaryExpression )
			int alt208=2;
			try { DebugEnterDecision(208, decisionCanBacktrack[208]);
			int LA208_0 = input.LA(1);

			if (((LA208_0>=Identifier && LA208_0<=NumericLiteral)||(LA208_0>=31 && LA208_0<=32)||LA208_0==35||(LA208_0>=58 && LA208_0<=59)||(LA208_0>=103 && LA208_0<=106)))
			{
				alt208=1;
			}
			else if (((LA208_0>=91 && LA208_0<=92)||(LA208_0>=96 && LA208_0<=102)))
			{
				alt208=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 208, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(208); }
			switch (alt208)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:340:4: postfixExpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(340, 4);
				PushFollow(Follow._postfixExpression_in_unaryExpression2275);
				postfixExpression407=postfixExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, postfixExpression407.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:341:4: ( 'delete' | 'void' | 'typeof' | '++' | '--' | '+' | '-' | '~' | '!' ) unaryExpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(341, 4);
				set408=(IToken)input.LT(1);
				if ((input.LA(1)>=91 && input.LA(1)<=92)||(input.LA(1)>=96 && input.LA(1)<=102))
				{
					input.Consume();
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set408));
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(341, 73);
				PushFollow(Follow._unaryExpression_in_unaryExpression2316);
				unaryExpression409=unaryExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression409.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("unaryExpression", 74);
			LeaveRule("unaryExpression", 74);
			Leave_unaryExpression();
			if (state.backtracking > 0) { Memoize(input, 74, unaryExpression_StartIndex); }
		}
		DebugLocation(342, 1);
		} finally { DebugExitRule(GrammarFileName, "unaryExpression"); }
		return retval;

	}
	// $ANTLR end "unaryExpression"

	public class postfixExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_postfixExpression();
	partial void Leave_postfixExpression();

	// $ANTLR start "postfixExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:344:1: postfixExpression : leftHandSideExpression ( '++' | '--' )? ;
	[GrammarRule("postfixExpression")]
	private JavaScriptParser.postfixExpression_return postfixExpression()
	{
		Enter_postfixExpression();
		EnterRule("postfixExpression", 75);
		TraceIn("postfixExpression", 75);
		JavaScriptParser.postfixExpression_return retval = new JavaScriptParser.postfixExpression_return();
		retval.Start = (IToken)input.LT(1);
		int postfixExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken set411=null;
		JavaScriptParser.leftHandSideExpression_return leftHandSideExpression410 = default(JavaScriptParser.leftHandSideExpression_return);

		object set411_tree=null;

		try { DebugEnterRule(GrammarFileName, "postfixExpression");
		DebugLocation(344, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 75)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:345:2: ( leftHandSideExpression ( '++' | '--' )? )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:345:4: leftHandSideExpression ( '++' | '--' )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(345, 4);
			PushFollow(Follow._leftHandSideExpression_in_postfixExpression2328);
			leftHandSideExpression410=leftHandSideExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftHandSideExpression410.Tree);
			DebugLocation(345, 27);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:345:27: ( '++' | '--' )?
			int alt209=2;
			try { DebugEnterSubRule(209);
			try { DebugEnterDecision(209, decisionCanBacktrack[209]);
			int LA209_0 = input.LA(1);

			if (((LA209_0>=99 && LA209_0<=100)))
			{
				alt209=1;
			}
			} finally { DebugExitDecision(209); }
			switch (alt209)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:
				{
				DebugLocation(345, 27);
				set411=(IToken)input.LT(1);
				if ((input.LA(1)>=99 && input.LA(1)<=100))
				{
					input.Consume();
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set411));
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}


				}
				break;

			}
			} finally { DebugExitSubRule(209); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("postfixExpression", 75);
			LeaveRule("postfixExpression", 75);
			Leave_postfixExpression();
			if (state.backtracking > 0) { Memoize(input, 75, postfixExpression_StartIndex); }
		}
		DebugLocation(346, 1);
		} finally { DebugExitRule(GrammarFileName, "postfixExpression"); }
		return retval;

	}
	// $ANTLR end "postfixExpression"

	public class primaryExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_primaryExpression();
	partial void Leave_primaryExpression();

	// $ANTLR start "primaryExpression"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:348:1: primaryExpression : ( 'this' | Identifier | literal | arrayLiteral | objectLiteral | '(' ( LT )* expression ( LT )* ')' );
	[GrammarRule("primaryExpression")]
	private JavaScriptParser.primaryExpression_return primaryExpression()
	{
		Enter_primaryExpression();
		EnterRule("primaryExpression", 76);
		TraceIn("primaryExpression", 76);
		JavaScriptParser.primaryExpression_return retval = new JavaScriptParser.primaryExpression_return();
		retval.Start = (IToken)input.LT(1);
		int primaryExpression_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal412=null;
		IToken Identifier413=null;
		IToken char_literal417=null;
		IToken LT418=null;
		IToken LT420=null;
		IToken char_literal421=null;
		JavaScriptParser.literal_return literal414 = default(JavaScriptParser.literal_return);
		JavaScriptParser.arrayLiteral_return arrayLiteral415 = default(JavaScriptParser.arrayLiteral_return);
		JavaScriptParser.objectLiteral_return objectLiteral416 = default(JavaScriptParser.objectLiteral_return);
		JavaScriptParser.expression_return expression419 = default(JavaScriptParser.expression_return);

		object string_literal412_tree=null;
		object Identifier413_tree=null;
		object char_literal417_tree=null;
		object LT418_tree=null;
		object LT420_tree=null;
		object char_literal421_tree=null;

		try { DebugEnterRule(GrammarFileName, "primaryExpression");
		DebugLocation(348, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 76)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:349:2: ( 'this' | Identifier | literal | arrayLiteral | objectLiteral | '(' ( LT )* expression ( LT )* ')' )
			int alt212=6;
			try { DebugEnterDecision(212, decisionCanBacktrack[212]);
			switch (input.LA(1))
			{
			case 103:
				{
				alt212=1;
				}
				break;
			case Identifier:
				{
				alt212=2;
				}
				break;
			case StringLiteral:
			case NumericLiteral:
			case 104:
			case 105:
			case 106:
				{
				alt212=3;
				}
				break;
			case 59:
				{
				alt212=4;
				}
				break;
			case 35:
				{
				alt212=5;
				}
				break;
			case 32:
				{
				alt212=6;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 212, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(212); }
			switch (alt212)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:349:4: 'this'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(349, 4);
				string_literal412=(IToken)Match(input,103,Follow._103_in_primaryExpression2348); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				string_literal412_tree = (object)adaptor.Create(string_literal412);
				adaptor.AddChild(root_0, string_literal412_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:350:4: Identifier
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(350, 4);
				Identifier413=(IToken)Match(input,Identifier,Follow._Identifier_in_primaryExpression2353); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				Identifier413_tree = (object)adaptor.Create(Identifier413);
				adaptor.AddChild(root_0, Identifier413_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:351:4: literal
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(351, 4);
				PushFollow(Follow._literal_in_primaryExpression2358);
				literal414=literal();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal414.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:352:4: arrayLiteral
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(352, 4);
				PushFollow(Follow._arrayLiteral_in_primaryExpression2363);
				arrayLiteral415=arrayLiteral();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayLiteral415.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:353:4: objectLiteral
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(353, 4);
				PushFollow(Follow._objectLiteral_in_primaryExpression2368);
				objectLiteral416=objectLiteral();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectLiteral416.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:354:4: '(' ( LT )* expression ( LT )* ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(354, 4);
				char_literal417=(IToken)Match(input,32,Follow._32_in_primaryExpression2373); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal417_tree = (object)adaptor.Create(char_literal417);
				adaptor.AddChild(root_0, char_literal417_tree);
				}
				DebugLocation(354, 10);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:354:10: ( LT )*
				try { DebugEnterSubRule(210);
				while (true)
				{
					int alt210=2;
					try { DebugEnterDecision(210, decisionCanBacktrack[210]);
					int LA210_0 = input.LA(1);

					if ((LA210_0==LT))
					{
						alt210=1;
					}


					} finally { DebugExitDecision(210); }
					switch ( alt210 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(354, 10);
						LT418=(IToken)Match(input,LT,Follow._LT_in_primaryExpression2375); if (state.failed) return retval;

						}
						break;

					default:
						goto loop210;
					}
				}

				loop210:
					;

				} finally { DebugExitSubRule(210); }

				DebugLocation(354, 13);
				PushFollow(Follow._expression_in_primaryExpression2379);
				expression419=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression419.Tree);
				DebugLocation(354, 26);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:354:26: ( LT )*
				try { DebugEnterSubRule(211);
				while (true)
				{
					int alt211=2;
					try { DebugEnterDecision(211, decisionCanBacktrack[211]);
					int LA211_0 = input.LA(1);

					if ((LA211_0==LT))
					{
						alt211=1;
					}


					} finally { DebugExitDecision(211); }
					switch ( alt211 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
						{
						DebugLocation(354, 26);
						LT420=(IToken)Match(input,LT,Follow._LT_in_primaryExpression2381); if (state.failed) return retval;

						}
						break;

					default:
						goto loop211;
					}
				}

				loop211:
					;

				} finally { DebugExitSubRule(211); }

				DebugLocation(354, 29);
				char_literal421=(IToken)Match(input,34,Follow._34_in_primaryExpression2385); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal421_tree = (object)adaptor.Create(char_literal421);
				adaptor.AddChild(root_0, char_literal421_tree);
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("primaryExpression", 76);
			LeaveRule("primaryExpression", 76);
			Leave_primaryExpression();
			if (state.backtracking > 0) { Memoize(input, 76, primaryExpression_StartIndex); }
		}
		DebugLocation(355, 1);
		} finally { DebugExitRule(GrammarFileName, "primaryExpression"); }
		return retval;

	}
	// $ANTLR end "primaryExpression"

	public class arrayLiteral_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arrayLiteral();
	partial void Leave_arrayLiteral();

	// $ANTLR start "arrayLiteral"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:358:1: arrayLiteral : '[' ( LT )* ( assignmentExpression )? ( ( LT )* ',' ( ( LT )* assignmentExpression )? )* ( LT )* ']' ;
	[GrammarRule("arrayLiteral")]
	private JavaScriptParser.arrayLiteral_return arrayLiteral()
	{
		Enter_arrayLiteral();
		EnterRule("arrayLiteral", 77);
		TraceIn("arrayLiteral", 77);
		JavaScriptParser.arrayLiteral_return retval = new JavaScriptParser.arrayLiteral_return();
		retval.Start = (IToken)input.LT(1);
		int arrayLiteral_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal422=null;
		IToken LT423=null;
		IToken LT425=null;
		IToken char_literal426=null;
		IToken LT427=null;
		IToken LT429=null;
		IToken char_literal430=null;
		JavaScriptParser.assignmentExpression_return assignmentExpression424 = default(JavaScriptParser.assignmentExpression_return);
		JavaScriptParser.assignmentExpression_return assignmentExpression428 = default(JavaScriptParser.assignmentExpression_return);

		object char_literal422_tree=null;
		object LT423_tree=null;
		object LT425_tree=null;
		object char_literal426_tree=null;
		object LT427_tree=null;
		object LT429_tree=null;
		object char_literal430_tree=null;

		try { DebugEnterRule(GrammarFileName, "arrayLiteral");
		DebugLocation(358, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 77)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:359:2: ( '[' ( LT )* ( assignmentExpression )? ( ( LT )* ',' ( ( LT )* assignmentExpression )? )* ( LT )* ']' )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:359:4: '[' ( LT )* ( assignmentExpression )? ( ( LT )* ',' ( ( LT )* assignmentExpression )? )* ( LT )* ']'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(359, 4);
			char_literal422=(IToken)Match(input,59,Follow._59_in_arrayLiteral2398); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal422_tree = (object)adaptor.Create(char_literal422);
			adaptor.AddChild(root_0, char_literal422_tree);
			}
			DebugLocation(359, 10);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:359:10: ( LT )*
			try { DebugEnterSubRule(213);
			while (true)
			{
				int alt213=2;
				try { DebugEnterDecision(213, decisionCanBacktrack[213]);
				int LA213_0 = input.LA(1);

				if ((LA213_0==LT))
				{
					int LA213_2 = input.LA(2);

					if ((EvaluatePredicate(synpred280_JavaScript_fragment)))
					{
						alt213=1;
					}


				}


				} finally { DebugExitDecision(213); }
				switch ( alt213 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(359, 10);
					LT423=(IToken)Match(input,LT,Follow._LT_in_arrayLiteral2400); if (state.failed) return retval;

					}
					break;

				default:
					goto loop213;
				}
			}

			loop213:
				;

			} finally { DebugExitSubRule(213); }

			DebugLocation(359, 13);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:359:13: ( assignmentExpression )?
			int alt214=2;
			try { DebugEnterSubRule(214);
			try { DebugEnterDecision(214, decisionCanBacktrack[214]);
			int LA214_0 = input.LA(1);

			if (((LA214_0>=Identifier && LA214_0<=NumericLiteral)||(LA214_0>=31 && LA214_0<=32)||LA214_0==35||(LA214_0>=58 && LA214_0<=59)||(LA214_0>=91 && LA214_0<=92)||(LA214_0>=96 && LA214_0<=106)))
			{
				alt214=1;
			}
			} finally { DebugExitDecision(214); }
			switch (alt214)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: assignmentExpression
				{
				DebugLocation(359, 13);
				PushFollow(Follow._assignmentExpression_in_arrayLiteral2404);
				assignmentExpression424=assignmentExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression424.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(214); }

			DebugLocation(359, 35);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:359:35: ( ( LT )* ',' ( ( LT )* assignmentExpression )? )*
			try { DebugEnterSubRule(218);
			while (true)
			{
				int alt218=2;
				try { DebugEnterDecision(218, decisionCanBacktrack[218]);
				try
				{
					alt218 = dfa218.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(218); }
				switch ( alt218 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:359:36: ( LT )* ',' ( ( LT )* assignmentExpression )?
					{
					DebugLocation(359, 38);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:359:38: ( LT )*
					try { DebugEnterSubRule(215);
					while (true)
					{
						int alt215=2;
						try { DebugEnterDecision(215, decisionCanBacktrack[215]);
						int LA215_0 = input.LA(1);

						if ((LA215_0==LT))
						{
							alt215=1;
						}


						} finally { DebugExitDecision(215); }
						switch ( alt215 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(359, 38);
							LT425=(IToken)Match(input,LT,Follow._LT_in_arrayLiteral2408); if (state.failed) return retval;

							}
							break;

						default:
							goto loop215;
						}
					}

					loop215:
						;

					} finally { DebugExitSubRule(215); }

					DebugLocation(359, 41);
					char_literal426=(IToken)Match(input,33,Follow._33_in_arrayLiteral2412); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					char_literal426_tree = (object)adaptor.Create(char_literal426);
					adaptor.AddChild(root_0, char_literal426_tree);
					}
					DebugLocation(359, 45);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:359:45: ( ( LT )* assignmentExpression )?
					int alt217=2;
					try { DebugEnterSubRule(217);
					try { DebugEnterDecision(217, decisionCanBacktrack[217]);
					try
					{
						alt217 = dfa217.Predict(input);
					}
					catch (NoViableAltException nvae)
					{
						DebugRecognitionException(nvae);
						throw;
					}
					} finally { DebugExitDecision(217); }
					switch (alt217)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:359:46: ( LT )* assignmentExpression
						{
						DebugLocation(359, 48);
						// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:359:48: ( LT )*
						try { DebugEnterSubRule(216);
						while (true)
						{
							int alt216=2;
							try { DebugEnterDecision(216, decisionCanBacktrack[216]);
							int LA216_0 = input.LA(1);

							if ((LA216_0==LT))
							{
								alt216=1;
							}


							} finally { DebugExitDecision(216); }
							switch ( alt216 )
							{
							case 1:
								DebugEnterAlt(1);
								// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
								{
								DebugLocation(359, 48);
								LT427=(IToken)Match(input,LT,Follow._LT_in_arrayLiteral2415); if (state.failed) return retval;

								}
								break;

							default:
								goto loop216;
							}
						}

						loop216:
							;

						} finally { DebugExitSubRule(216); }

						DebugLocation(359, 51);
						PushFollow(Follow._assignmentExpression_in_arrayLiteral2419);
						assignmentExpression428=assignmentExpression();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression428.Tree);

						}
						break;

					}
					} finally { DebugExitSubRule(217); }


					}
					break;

				default:
					goto loop218;
				}
			}

			loop218:
				;

			} finally { DebugExitSubRule(218); }

			DebugLocation(359, 78);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:359:78: ( LT )*
			try { DebugEnterSubRule(219);
			while (true)
			{
				int alt219=2;
				try { DebugEnterDecision(219, decisionCanBacktrack[219]);
				int LA219_0 = input.LA(1);

				if ((LA219_0==LT))
				{
					alt219=1;
				}


				} finally { DebugExitDecision(219); }
				switch ( alt219 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(359, 78);
					LT429=(IToken)Match(input,LT,Follow._LT_in_arrayLiteral2425); if (state.failed) return retval;

					}
					break;

				default:
					goto loop219;
				}
			}

			loop219:
				;

			} finally { DebugExitSubRule(219); }

			DebugLocation(359, 81);
			char_literal430=(IToken)Match(input,60,Follow._60_in_arrayLiteral2429); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal430_tree = (object)adaptor.Create(char_literal430);
			adaptor.AddChild(root_0, char_literal430_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("arrayLiteral", 77);
			LeaveRule("arrayLiteral", 77);
			Leave_arrayLiteral();
			if (state.backtracking > 0) { Memoize(input, 77, arrayLiteral_StartIndex); }
		}
		DebugLocation(360, 1);
		} finally { DebugExitRule(GrammarFileName, "arrayLiteral"); }
		return retval;

	}
	// $ANTLR end "arrayLiteral"

	public class objectLiteral_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_objectLiteral();
	partial void Leave_objectLiteral();

	// $ANTLR start "objectLiteral"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:363:1: objectLiteral : '{' ( LT )* propertyNameAndValue ( ( LT )* ',' ( LT )* propertyNameAndValue )* ( LT )* '}' ;
	[GrammarRule("objectLiteral")]
	private JavaScriptParser.objectLiteral_return objectLiteral()
	{
		Enter_objectLiteral();
		EnterRule("objectLiteral", 78);
		TraceIn("objectLiteral", 78);
		JavaScriptParser.objectLiteral_return retval = new JavaScriptParser.objectLiteral_return();
		retval.Start = (IToken)input.LT(1);
		int objectLiteral_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal431=null;
		IToken LT432=null;
		IToken LT434=null;
		IToken char_literal435=null;
		IToken LT436=null;
		IToken LT438=null;
		IToken char_literal439=null;
		JavaScriptParser.propertyNameAndValue_return propertyNameAndValue433 = default(JavaScriptParser.propertyNameAndValue_return);
		JavaScriptParser.propertyNameAndValue_return propertyNameAndValue437 = default(JavaScriptParser.propertyNameAndValue_return);

		object char_literal431_tree=null;
		object LT432_tree=null;
		object LT434_tree=null;
		object char_literal435_tree=null;
		object LT436_tree=null;
		object LT438_tree=null;
		object char_literal439_tree=null;

		try { DebugEnterRule(GrammarFileName, "objectLiteral");
		DebugLocation(363, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 78)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:364:2: ( '{' ( LT )* propertyNameAndValue ( ( LT )* ',' ( LT )* propertyNameAndValue )* ( LT )* '}' )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:364:4: '{' ( LT )* propertyNameAndValue ( ( LT )* ',' ( LT )* propertyNameAndValue )* ( LT )* '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(364, 4);
			char_literal431=(IToken)Match(input,35,Follow._35_in_objectLiteral2448); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal431_tree = (object)adaptor.Create(char_literal431);
			adaptor.AddChild(root_0, char_literal431_tree);
			}
			DebugLocation(364, 10);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:364:10: ( LT )*
			try { DebugEnterSubRule(220);
			while (true)
			{
				int alt220=2;
				try { DebugEnterDecision(220, decisionCanBacktrack[220]);
				int LA220_0 = input.LA(1);

				if ((LA220_0==LT))
				{
					alt220=1;
				}


				} finally { DebugExitDecision(220); }
				switch ( alt220 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(364, 10);
					LT432=(IToken)Match(input,LT,Follow._LT_in_objectLiteral2450); if (state.failed) return retval;

					}
					break;

				default:
					goto loop220;
				}
			}

			loop220:
				;

			} finally { DebugExitSubRule(220); }

			DebugLocation(364, 13);
			PushFollow(Follow._propertyNameAndValue_in_objectLiteral2454);
			propertyNameAndValue433=propertyNameAndValue();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, propertyNameAndValue433.Tree);
			DebugLocation(364, 34);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:364:34: ( ( LT )* ',' ( LT )* propertyNameAndValue )*
			try { DebugEnterSubRule(223);
			while (true)
			{
				int alt223=2;
				try { DebugEnterDecision(223, decisionCanBacktrack[223]);
				try
				{
					alt223 = dfa223.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(223); }
				switch ( alt223 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:364:35: ( LT )* ',' ( LT )* propertyNameAndValue
					{
					DebugLocation(364, 37);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:364:37: ( LT )*
					try { DebugEnterSubRule(221);
					while (true)
					{
						int alt221=2;
						try { DebugEnterDecision(221, decisionCanBacktrack[221]);
						int LA221_0 = input.LA(1);

						if ((LA221_0==LT))
						{
							alt221=1;
						}


						} finally { DebugExitDecision(221); }
						switch ( alt221 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(364, 37);
							LT434=(IToken)Match(input,LT,Follow._LT_in_objectLiteral2457); if (state.failed) return retval;

							}
							break;

						default:
							goto loop221;
						}
					}

					loop221:
						;

					} finally { DebugExitSubRule(221); }

					DebugLocation(364, 40);
					char_literal435=(IToken)Match(input,33,Follow._33_in_objectLiteral2461); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					char_literal435_tree = (object)adaptor.Create(char_literal435);
					adaptor.AddChild(root_0, char_literal435_tree);
					}
					DebugLocation(364, 46);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:364:46: ( LT )*
					try { DebugEnterSubRule(222);
					while (true)
					{
						int alt222=2;
						try { DebugEnterDecision(222, decisionCanBacktrack[222]);
						int LA222_0 = input.LA(1);

						if ((LA222_0==LT))
						{
							alt222=1;
						}


						} finally { DebugExitDecision(222); }
						switch ( alt222 )
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
							{
							DebugLocation(364, 46);
							LT436=(IToken)Match(input,LT,Follow._LT_in_objectLiteral2463); if (state.failed) return retval;

							}
							break;

						default:
							goto loop222;
						}
					}

					loop222:
						;

					} finally { DebugExitSubRule(222); }

					DebugLocation(364, 49);
					PushFollow(Follow._propertyNameAndValue_in_objectLiteral2467);
					propertyNameAndValue437=propertyNameAndValue();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, propertyNameAndValue437.Tree);

					}
					break;

				default:
					goto loop223;
				}
			}

			loop223:
				;

			} finally { DebugExitSubRule(223); }

			DebugLocation(364, 74);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:364:74: ( LT )*
			try { DebugEnterSubRule(224);
			while (true)
			{
				int alt224=2;
				try { DebugEnterDecision(224, decisionCanBacktrack[224]);
				int LA224_0 = input.LA(1);

				if ((LA224_0==LT))
				{
					alt224=1;
				}


				} finally { DebugExitDecision(224); }
				switch ( alt224 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(364, 74);
					LT438=(IToken)Match(input,LT,Follow._LT_in_objectLiteral2471); if (state.failed) return retval;

					}
					break;

				default:
					goto loop224;
				}
			}

			loop224:
				;

			} finally { DebugExitSubRule(224); }

			DebugLocation(364, 77);
			char_literal439=(IToken)Match(input,36,Follow._36_in_objectLiteral2475); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal439_tree = (object)adaptor.Create(char_literal439);
			adaptor.AddChild(root_0, char_literal439_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("objectLiteral", 78);
			LeaveRule("objectLiteral", 78);
			Leave_objectLiteral();
			if (state.backtracking > 0) { Memoize(input, 78, objectLiteral_StartIndex); }
		}
		DebugLocation(365, 1);
		} finally { DebugExitRule(GrammarFileName, "objectLiteral"); }
		return retval;

	}
	// $ANTLR end "objectLiteral"

	public class propertyNameAndValue_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_propertyNameAndValue();
	partial void Leave_propertyNameAndValue();

	// $ANTLR start "propertyNameAndValue"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:367:1: propertyNameAndValue : propertyName ( LT )* ':' ( LT )* assignmentExpression ;
	[GrammarRule("propertyNameAndValue")]
	private JavaScriptParser.propertyNameAndValue_return propertyNameAndValue()
	{
		Enter_propertyNameAndValue();
		EnterRule("propertyNameAndValue", 79);
		TraceIn("propertyNameAndValue", 79);
		JavaScriptParser.propertyNameAndValue_return retval = new JavaScriptParser.propertyNameAndValue_return();
		retval.Start = (IToken)input.LT(1);
		int propertyNameAndValue_StartIndex = input.Index;
		object root_0 = null;

		IToken LT441=null;
		IToken char_literal442=null;
		IToken LT443=null;
		JavaScriptParser.propertyName_return propertyName440 = default(JavaScriptParser.propertyName_return);
		JavaScriptParser.assignmentExpression_return assignmentExpression444 = default(JavaScriptParser.assignmentExpression_return);

		object LT441_tree=null;
		object char_literal442_tree=null;
		object LT443_tree=null;

		try { DebugEnterRule(GrammarFileName, "propertyNameAndValue");
		DebugLocation(367, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 79)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:368:2: ( propertyName ( LT )* ':' ( LT )* assignmentExpression )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:368:4: propertyName ( LT )* ':' ( LT )* assignmentExpression
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(368, 4);
			PushFollow(Follow._propertyName_in_propertyNameAndValue2487);
			propertyName440=propertyName();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, propertyName440.Tree);
			DebugLocation(368, 19);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:368:19: ( LT )*
			try { DebugEnterSubRule(225);
			while (true)
			{
				int alt225=2;
				try { DebugEnterDecision(225, decisionCanBacktrack[225]);
				int LA225_0 = input.LA(1);

				if ((LA225_0==LT))
				{
					alt225=1;
				}


				} finally { DebugExitDecision(225); }
				switch ( alt225 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(368, 19);
					LT441=(IToken)Match(input,LT,Follow._LT_in_propertyNameAndValue2489); if (state.failed) return retval;

					}
					break;

				default:
					goto loop225;
				}
			}

			loop225:
				;

			} finally { DebugExitSubRule(225); }

			DebugLocation(368, 22);
			char_literal442=(IToken)Match(input,50,Follow._50_in_propertyNameAndValue2493); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal442_tree = (object)adaptor.Create(char_literal442);
			adaptor.AddChild(root_0, char_literal442_tree);
			}
			DebugLocation(368, 28);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:368:28: ( LT )*
			try { DebugEnterSubRule(226);
			while (true)
			{
				int alt226=2;
				try { DebugEnterDecision(226, decisionCanBacktrack[226]);
				int LA226_0 = input.LA(1);

				if ((LA226_0==LT))
				{
					alt226=1;
				}


				} finally { DebugExitDecision(226); }
				switch ( alt226 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(368, 28);
					LT443=(IToken)Match(input,LT,Follow._LT_in_propertyNameAndValue2495); if (state.failed) return retval;

					}
					break;

				default:
					goto loop226;
				}
			}

			loop226:
				;

			} finally { DebugExitSubRule(226); }

			DebugLocation(368, 31);
			PushFollow(Follow._assignmentExpression_in_propertyNameAndValue2499);
			assignmentExpression444=assignmentExpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression444.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("propertyNameAndValue", 79);
			LeaveRule("propertyNameAndValue", 79);
			Leave_propertyNameAndValue();
			if (state.backtracking > 0) { Memoize(input, 79, propertyNameAndValue_StartIndex); }
		}
		DebugLocation(369, 1);
		} finally { DebugExitRule(GrammarFileName, "propertyNameAndValue"); }
		return retval;

	}
	// $ANTLR end "propertyNameAndValue"

	public class propertyName_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_propertyName();
	partial void Leave_propertyName();

	// $ANTLR start "propertyName"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:371:1: propertyName : ( Identifier | StringLiteral | NumericLiteral );
	[GrammarRule("propertyName")]
	private JavaScriptParser.propertyName_return propertyName()
	{
		Enter_propertyName();
		EnterRule("propertyName", 80);
		TraceIn("propertyName", 80);
		JavaScriptParser.propertyName_return retval = new JavaScriptParser.propertyName_return();
		retval.Start = (IToken)input.LT(1);
		int propertyName_StartIndex = input.Index;
		object root_0 = null;

		IToken set445=null;

		object set445_tree=null;

		try { DebugEnterRule(GrammarFileName, "propertyName");
		DebugLocation(371, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 80)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:372:2: ( Identifier | StringLiteral | NumericLiteral )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(372, 2);
			set445=(IToken)input.LT(1);
			if ((input.LA(1)>=Identifier && input.LA(1)<=NumericLiteral))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set445));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("propertyName", 80);
			LeaveRule("propertyName", 80);
			Leave_propertyName();
			if (state.backtracking > 0) { Memoize(input, 80, propertyName_StartIndex); }
		}
		DebugLocation(375, 1);
		} finally { DebugExitRule(GrammarFileName, "propertyName"); }
		return retval;

	}
	// $ANTLR end "propertyName"

	public class literal_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_literal();
	partial void Leave_literal();

	// $ANTLR start "literal"
	// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:378:1: literal : ( 'null' | 'true' | 'false' | StringLiteral | NumericLiteral );
	[GrammarRule("literal")]
	private JavaScriptParser.literal_return literal()
	{
		Enter_literal();
		EnterRule("literal", 81);
		TraceIn("literal", 81);
		JavaScriptParser.literal_return retval = new JavaScriptParser.literal_return();
		retval.Start = (IToken)input.LT(1);
		int literal_StartIndex = input.Index;
		object root_0 = null;

		IToken set446=null;

		object set446_tree=null;

		try { DebugEnterRule(GrammarFileName, "literal");
		DebugLocation(378, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 81)) { return retval; }
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:379:2: ( 'null' | 'true' | 'false' | StringLiteral | NumericLiteral )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(379, 2);
			set446=(IToken)input.LT(1);
			if ((input.LA(1)>=StringLiteral && input.LA(1)<=NumericLiteral)||(input.LA(1)>=104 && input.LA(1)<=106))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set446));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("literal", 81);
			LeaveRule("literal", 81);
			Leave_literal();
			if (state.backtracking > 0) { Memoize(input, 81, literal_StartIndex); }
		}
		DebugLocation(384, 1);
		} finally { DebugExitRule(GrammarFileName, "literal"); }
		return retval;

	}
	// $ANTLR end "literal"

	partial void Enter_synpred5_JavaScript_fragment();
	partial void Leave_synpred5_JavaScript_fragment();

	// $ANTLR start synpred5_JavaScript
	public void synpred5_JavaScript_fragment()
	{
		Enter_synpred5_JavaScript_fragment();
		EnterRule("synpred5_JavaScript_fragment", 86);
		TraceIn("synpred5_JavaScript_fragment", 86);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:27:4: ( functionDeclaration )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:27:4: functionDeclaration
			{
			DebugLocation(27, 4);
			PushFollow(Follow._functionDeclaration_in_synpred5_JavaScript93);
			functionDeclaration();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred5_JavaScript_fragment", 86);
			LeaveRule("synpred5_JavaScript_fragment", 86);
			Leave_synpred5_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred5_JavaScript

	partial void Enter_synpred9_JavaScript_fragment();
	partial void Leave_synpred9_JavaScript_fragment();

	// $ANTLR start synpred9_JavaScript
	public void synpred9_JavaScript_fragment()
	{
		Enter_synpred9_JavaScript_fragment();
		EnterRule("synpred9_JavaScript_fragment", 90);
		TraceIn("synpred9_JavaScript_fragment", 90);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:37:15: ( LT )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:37:15: LT
			{
			DebugLocation(37, 15);
			Match(input,LT,Follow._LT_in_synpred9_JavaScript143); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred9_JavaScript_fragment", 90);
			LeaveRule("synpred9_JavaScript_fragment", 90);
			Leave_synpred9_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred9_JavaScript

	partial void Enter_synpred21_JavaScript_fragment();
	partial void Leave_synpred21_JavaScript_fragment();

	// $ANTLR start synpred21_JavaScript
	public void synpred21_JavaScript_fragment()
	{
		Enter_synpred21_JavaScript_fragment();
		EnterRule("synpred21_JavaScript_fragment", 102);
		TraceIn("synpred21_JavaScript_fragment", 102);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:50:4: ( statementBlock )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:50:4: statementBlock
			{
			DebugLocation(50, 4);
			PushFollow(Follow._statementBlock_in_synpred21_JavaScript237);
			statementBlock();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred21_JavaScript_fragment", 102);
			LeaveRule("synpred21_JavaScript_fragment", 102);
			Leave_synpred21_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred21_JavaScript

	partial void Enter_synpred24_JavaScript_fragment();
	partial void Leave_synpred24_JavaScript_fragment();

	// $ANTLR start synpred24_JavaScript
	public void synpred24_JavaScript_fragment()
	{
		Enter_synpred24_JavaScript_fragment();
		EnterRule("synpred24_JavaScript_fragment", 105);
		TraceIn("synpred24_JavaScript_fragment", 105);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:53:4: ( expressionStatement )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:53:4: expressionStatement
			{
			DebugLocation(53, 4);
			PushFollow(Follow._expressionStatement_in_synpred24_JavaScript252);
			expressionStatement();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred24_JavaScript_fragment", 105);
			LeaveRule("synpred24_JavaScript_fragment", 105);
			Leave_synpred24_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred24_JavaScript

	partial void Enter_synpred31_JavaScript_fragment();
	partial void Leave_synpred31_JavaScript_fragment();

	// $ANTLR start synpred31_JavaScript
	public void synpred31_JavaScript_fragment()
	{
		Enter_synpred31_JavaScript_fragment();
		EnterRule("synpred31_JavaScript_fragment", 112);
		TraceIn("synpred31_JavaScript_fragment", 112);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:60:4: ( labelledStatement )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:60:4: labelledStatement
			{
			DebugLocation(60, 4);
			PushFollow(Follow._labelledStatement_in_synpred31_JavaScript287);
			labelledStatement();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred31_JavaScript_fragment", 112);
			LeaveRule("synpred31_JavaScript_fragment", 112);
			Leave_synpred31_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred31_JavaScript

	partial void Enter_synpred34_JavaScript_fragment();
	partial void Leave_synpred34_JavaScript_fragment();

	// $ANTLR start synpred34_JavaScript
	public void synpred34_JavaScript_fragment()
	{
		Enter_synpred34_JavaScript_fragment();
		EnterRule("synpred34_JavaScript_fragment", 115);
		TraceIn("synpred34_JavaScript_fragment", 115);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:67:8: ( LT )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:67:8: LT
			{
			DebugLocation(67, 8);
			Match(input,LT,Follow._LT_in_synpred34_JavaScript316); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred34_JavaScript_fragment", 115);
			LeaveRule("synpred34_JavaScript_fragment", 115);
			Leave_synpred34_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred34_JavaScript

	partial void Enter_synpred47_JavaScript_fragment();
	partial void Leave_synpred47_JavaScript_fragment();

	// $ANTLR start synpred47_JavaScript
	public void synpred47_JavaScript_fragment()
	{
		Enter_synpred47_JavaScript_fragment();
		EnterRule("synpred47_JavaScript_fragment", 128);
		TraceIn("synpred47_JavaScript_fragment", 128);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:87:15: ( LT )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:87:15: LT
			{
			DebugLocation(87, 15);
			Match(input,LT,Follow._LT_in_synpred47_JavaScript443); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred47_JavaScript_fragment", 128);
			LeaveRule("synpred47_JavaScript_fragment", 128);
			Leave_synpred47_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred47_JavaScript

	partial void Enter_synpred49_JavaScript_fragment();
	partial void Leave_synpred49_JavaScript_fragment();

	// $ANTLR start synpred49_JavaScript
	public void synpred49_JavaScript_fragment()
	{
		Enter_synpred49_JavaScript_fragment();
		EnterRule("synpred49_JavaScript_fragment", 130);
		TraceIn("synpred49_JavaScript_fragment", 130);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:91:15: ( LT )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:91:15: LT
			{
			DebugLocation(91, 15);
			Match(input,LT,Follow._LT_in_synpred49_JavaScript462); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred49_JavaScript_fragment", 130);
			LeaveRule("synpred49_JavaScript_fragment", 130);
			Leave_synpred49_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred49_JavaScript

	partial void Enter_synpred60_JavaScript_fragment();
	partial void Leave_synpred60_JavaScript_fragment();

	// $ANTLR start synpred60_JavaScript
	public void synpred60_JavaScript_fragment()
	{
		Enter_synpred60_JavaScript_fragment();
		EnterRule("synpred60_JavaScript_fragment", 141);
		TraceIn("synpred60_JavaScript_fragment", 141);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:111:59: ( ( LT )* 'else' ( LT )* statement )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:111:59: ( LT )* 'else' ( LT )* statement
			{
			DebugLocation(111, 61);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:111:61: ( LT )*
			try { DebugEnterSubRule(239);
			while (true)
			{
				int alt239=2;
				try { DebugEnterDecision(239, decisionCanBacktrack[239]);
				int LA239_0 = input.LA(1);

				if ((LA239_0==LT))
				{
					alt239=1;
				}


				} finally { DebugExitDecision(239); }
				switch ( alt239 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(111, 59);
					Match(input,LT,Follow._LT_in_synpred60_JavaScript575); if (state.failed) return;

					}
					break;

				default:
					goto loop239;
				}
			}

			loop239:
				;

			} finally { DebugExitSubRule(239); }

			DebugLocation(111, 64);
			Match(input,41,Follow._41_in_synpred60_JavaScript579); if (state.failed) return;
			DebugLocation(111, 73);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:111:73: ( LT )*
			try { DebugEnterSubRule(240);
			while (true)
			{
				int alt240=2;
				try { DebugEnterDecision(240, decisionCanBacktrack[240]);
				int LA240_0 = input.LA(1);

				if ((LA240_0==LT))
				{
					alt240=1;
				}


				} finally { DebugExitDecision(240); }
				switch ( alt240 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(111, 71);
					Match(input,LT,Follow._LT_in_synpred60_JavaScript581); if (state.failed) return;

					}
					break;

				default:
					goto loop240;
				}
			}

			loop240:
				;

			} finally { DebugExitSubRule(240); }

			DebugLocation(111, 76);
			PushFollow(Follow._statement_in_synpred60_JavaScript585);
			statement();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred60_JavaScript_fragment", 141);
			LeaveRule("synpred60_JavaScript_fragment", 141);
			Leave_synpred60_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred60_JavaScript

	partial void Enter_synpred63_JavaScript_fragment();
	partial void Leave_synpred63_JavaScript_fragment();

	// $ANTLR start synpred63_JavaScript
	public void synpred63_JavaScript_fragment()
	{
		Enter_synpred63_JavaScript_fragment();
		EnterRule("synpred63_JavaScript_fragment", 144);
		TraceIn("synpred63_JavaScript_fragment", 144);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:117:4: ( forStatement )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:117:4: forStatement
			{
			DebugLocation(117, 4);
			PushFollow(Follow._forStatement_in_synpred63_JavaScript609);
			forStatement();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred63_JavaScript_fragment", 144);
			LeaveRule("synpred63_JavaScript_fragment", 144);
			Leave_synpred63_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred63_JavaScript

	partial void Enter_synpred118_JavaScript_fragment();
	partial void Leave_synpred118_JavaScript_fragment();

	// $ANTLR start synpred118_JavaScript
	public void synpred118_JavaScript_fragment()
	{
		Enter_synpred118_JavaScript_fragment();
		EnterRule("synpred118_JavaScript_fragment", 199);
		TraceIn("synpred118_JavaScript_fragment", 199);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:176:36: ( LT )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:176:36: LT
			{
			DebugLocation(176, 36);
			Match(input,LT,Follow._LT_in_synpred118_JavaScript1090); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred118_JavaScript_fragment", 199);
			LeaveRule("synpred118_JavaScript_fragment", 199);
			Leave_synpred118_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred118_JavaScript

	partial void Enter_synpred121_JavaScript_fragment();
	partial void Leave_synpred121_JavaScript_fragment();

	// $ANTLR start synpred121_JavaScript
	public void synpred121_JavaScript_fragment()
	{
		Enter_synpred121_JavaScript_fragment();
		EnterRule("synpred121_JavaScript_fragment", 202);
		TraceIn("synpred121_JavaScript_fragment", 202);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:180:23: ( LT )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:180:23: LT
			{
			DebugLocation(180, 23);
			Match(input,LT,Follow._LT_in_synpred121_JavaScript1115); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred121_JavaScript_fragment", 202);
			LeaveRule("synpred121_JavaScript_fragment", 202);
			Leave_synpred121_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred121_JavaScript

	partial void Enter_synpred140_JavaScript_fragment();
	partial void Leave_synpred140_JavaScript_fragment();

	// $ANTLR start synpred140_JavaScript
	public void synpred140_JavaScript_fragment()
	{
		Enter_synpred140_JavaScript_fragment();
		EnterRule("synpred140_JavaScript_fragment", 221);
		TraceIn("synpred140_JavaScript_fragment", 221);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:209:4: ( conditionalExpression )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:209:4: conditionalExpression
			{
			DebugLocation(209, 4);
			PushFollow(Follow._conditionalExpression_in_synpred140_JavaScript1307);
			conditionalExpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred140_JavaScript_fragment", 221);
			LeaveRule("synpred140_JavaScript_fragment", 221);
			Leave_synpred140_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred140_JavaScript

	partial void Enter_synpred143_JavaScript_fragment();
	partial void Leave_synpred143_JavaScript_fragment();

	// $ANTLR start synpred143_JavaScript
	public void synpred143_JavaScript_fragment()
	{
		Enter_synpred143_JavaScript_fragment();
		EnterRule("synpred143_JavaScript_fragment", 224);
		TraceIn("synpred143_JavaScript_fragment", 224);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:214:4: ( conditionalExpressionNoIn )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:214:4: conditionalExpressionNoIn
			{
			DebugLocation(214, 4);
			PushFollow(Follow._conditionalExpressionNoIn_in_synpred143_JavaScript1336);
			conditionalExpressionNoIn();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred143_JavaScript_fragment", 224);
			LeaveRule("synpred143_JavaScript_fragment", 224);
			Leave_synpred143_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred143_JavaScript

	partial void Enter_synpred146_JavaScript_fragment();
	partial void Leave_synpred146_JavaScript_fragment();

	// $ANTLR start synpred146_JavaScript
	public void synpred146_JavaScript_fragment()
	{
		Enter_synpred146_JavaScript_fragment();
		EnterRule("synpred146_JavaScript_fragment", 227);
		TraceIn("synpred146_JavaScript_fragment", 227);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:219:4: ( callExpression )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:219:4: callExpression
			{
			DebugLocation(219, 4);
			PushFollow(Follow._callExpression_in_synpred146_JavaScript1365);
			callExpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred146_JavaScript_fragment", 227);
			LeaveRule("synpred146_JavaScript_fragment", 227);
			Leave_synpred146_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred146_JavaScript

	partial void Enter_synpred147_JavaScript_fragment();
	partial void Leave_synpred147_JavaScript_fragment();

	// $ANTLR start synpred147_JavaScript
	public void synpred147_JavaScript_fragment()
	{
		Enter_synpred147_JavaScript_fragment();
		EnterRule("synpred147_JavaScript_fragment", 228);
		TraceIn("synpred147_JavaScript_fragment", 228);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:224:4: ( memberExpression )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:224:4: memberExpression
			{
			DebugLocation(224, 4);
			PushFollow(Follow._memberExpression_in_synpred147_JavaScript1382);
			memberExpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred147_JavaScript_fragment", 228);
			LeaveRule("synpred147_JavaScript_fragment", 228);
			Leave_synpred147_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred147_JavaScript

	partial void Enter_synpred154_JavaScript_fragment();
	partial void Leave_synpred154_JavaScript_fragment();

	// $ANTLR start synpred154_JavaScript
	public void synpred154_JavaScript_fragment()
	{
		Enter_synpred154_JavaScript_fragment();
		EnterRule("synpred154_JavaScript_fragment", 235);
		TraceIn("synpred154_JavaScript_fragment", 235);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:229:91: ( ( LT )* memberExpressionSuffix )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:229:91: ( LT )* memberExpressionSuffix
			{
			DebugLocation(229, 93);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:229:93: ( LT )*
			try { DebugEnterSubRule(254);
			while (true)
			{
				int alt254=2;
				try { DebugEnterDecision(254, decisionCanBacktrack[254]);
				int LA254_0 = input.LA(1);

				if ((LA254_0==LT))
				{
					alt254=1;
				}


				} finally { DebugExitDecision(254); }
				switch ( alt254 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(229, 91);
					Match(input,LT,Follow._LT_in_synpred154_JavaScript1430); if (state.failed) return;

					}
					break;

				default:
					goto loop254;
				}
			}

			loop254:
				;

			} finally { DebugExitSubRule(254); }

			DebugLocation(229, 96);
			PushFollow(Follow._memberExpressionSuffix_in_synpred154_JavaScript1434);
			memberExpressionSuffix();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred154_JavaScript_fragment", 235);
			LeaveRule("synpred154_JavaScript_fragment", 235);
			Leave_synpred154_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred154_JavaScript

	partial void Enter_synpred158_JavaScript_fragment();
	partial void Leave_synpred158_JavaScript_fragment();

	// $ANTLR start synpred158_JavaScript
	public void synpred158_JavaScript_fragment()
	{
		Enter_synpred158_JavaScript_fragment();
		EnterRule("synpred158_JavaScript_fragment", 239);
		TraceIn("synpred158_JavaScript_fragment", 239);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:238:37: ( ( LT )* callExpressionSuffix )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:238:37: ( LT )* callExpressionSuffix
			{
			DebugLocation(238, 39);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:238:39: ( LT )*
			try { DebugEnterSubRule(255);
			while (true)
			{
				int alt255=2;
				try { DebugEnterDecision(255, decisionCanBacktrack[255]);
				int LA255_0 = input.LA(1);

				if ((LA255_0==LT))
				{
					alt255=1;
				}


				} finally { DebugExitDecision(255); }
				switch ( alt255 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(238, 37);
					Match(input,LT,Follow._LT_in_synpred158_JavaScript1473); if (state.failed) return;

					}
					break;

				default:
					goto loop255;
				}
			}

			loop255:
				;

			} finally { DebugExitSubRule(255); }

			DebugLocation(238, 42);
			PushFollow(Follow._callExpressionSuffix_in_synpred158_JavaScript1477);
			callExpressionSuffix();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred158_JavaScript_fragment", 239);
			LeaveRule("synpred158_JavaScript_fragment", 239);
			Leave_synpred158_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred158_JavaScript

	partial void Enter_synpred256_JavaScript_fragment();
	partial void Leave_synpred256_JavaScript_fragment();

	// $ANTLR start synpred256_JavaScript
	public void synpred256_JavaScript_fragment()
	{
		Enter_synpred256_JavaScript_fragment();
		EnterRule("synpred256_JavaScript_fragment", 337);
		TraceIn("synpred256_JavaScript_fragment", 337);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:332:30: ( ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:332:30: ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression
			{
			DebugLocation(332, 32);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:332:32: ( LT )*
			try { DebugEnterSubRule(300);
			while (true)
			{
				int alt300=2;
				try { DebugEnterDecision(300, decisionCanBacktrack[300]);
				int LA300_0 = input.LA(1);

				if ((LA300_0==LT))
				{
					alt300=1;
				}


				} finally { DebugExitDecision(300); }
				switch ( alt300 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(332, 30);
					Match(input,LT,Follow._LT_in_synpred256_JavaScript2210); if (state.failed) return;

					}
					break;

				default:
					goto loop300;
				}
			}

			loop300:
				;

			} finally { DebugExitSubRule(300); }

			DebugLocation(332, 35);
			if ((input.LA(1)>=91 && input.LA(1)<=92))
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(332, 49);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:332:49: ( LT )*
			try { DebugEnterSubRule(301);
			while (true)
			{
				int alt301=2;
				try { DebugEnterDecision(301, decisionCanBacktrack[301]);
				int LA301_0 = input.LA(1);

				if ((LA301_0==LT))
				{
					alt301=1;
				}


				} finally { DebugExitDecision(301); }
				switch ( alt301 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:0:0: LT
					{
					DebugLocation(332, 47);
					Match(input,LT,Follow._LT_in_synpred256_JavaScript2222); if (state.failed) return;

					}
					break;

				default:
					goto loop301;
				}
			}

			loop301:
				;

			} finally { DebugExitSubRule(301); }

			DebugLocation(332, 52);
			PushFollow(Follow._multiplicativeExpression_in_synpred256_JavaScript2226);
			multiplicativeExpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred256_JavaScript_fragment", 337);
			LeaveRule("synpred256_JavaScript_fragment", 337);
			Leave_synpred256_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred256_JavaScript

	partial void Enter_synpred280_JavaScript_fragment();
	partial void Leave_synpred280_JavaScript_fragment();

	// $ANTLR start synpred280_JavaScript
	public void synpred280_JavaScript_fragment()
	{
		Enter_synpred280_JavaScript_fragment();
		EnterRule("synpred280_JavaScript_fragment", 361);
		TraceIn("synpred280_JavaScript_fragment", 361);
		try
		{
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:359:8: ( LT )
			DebugEnterAlt(1);
			// C:\\Users\\Jacob T. Nielsen\\Downloads\\JavaScript.g:359:8: LT
			{
			DebugLocation(359, 8);
			Match(input,LT,Follow._LT_in_synpred280_JavaScript2400); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred280_JavaScript_fragment", 361);
			LeaveRule("synpred280_JavaScript_fragment", 361);
			Leave_synpred280_JavaScript_fragment();
		}
	}
	// $ANTLR end synpred280_JavaScript
	#endregion Rules

	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region DFA
	DFA4 dfa4;
	DFA5 dfa5;
	DFA17 dfa17;
	DFA16 dfa16;
	DFA21 dfa21;
	DFA26 dfa26;
	DFA30 dfa30;
	DFA33 dfa33;
	DFA57 dfa57;
	DFA60 dfa60;
	DFA63 dfa63;
	DFA90 dfa90;
	DFA94 dfa94;
	DFA93 dfa93;
	DFA106 dfa106;
	DFA115 dfa115;
	DFA118 dfa118;
	DFA121 dfa121;
	DFA124 dfa124;
	DFA125 dfa125;
	DFA127 dfa127;
	DFA132 dfa132;
	DFA136 dfa136;
	DFA142 dfa142;
	DFA141 dfa141;
	DFA151 dfa151;
	DFA156 dfa156;
	DFA159 dfa159;
	DFA162 dfa162;
	DFA165 dfa165;
	DFA168 dfa168;
	DFA171 dfa171;
	DFA174 dfa174;
	DFA177 dfa177;
	DFA180 dfa180;
	DFA183 dfa183;
	DFA186 dfa186;
	DFA189 dfa189;
	DFA192 dfa192;
	DFA195 dfa195;
	DFA198 dfa198;
	DFA201 dfa201;
	DFA204 dfa204;
	DFA207 dfa207;
	DFA218 dfa218;
	DFA217 dfa217;
	DFA223 dfa223;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa4 = new DFA4( this );
		dfa5 = new DFA5( this, SpecialStateTransition5 );
		dfa17 = new DFA17( this );
		dfa16 = new DFA16( this );
		dfa21 = new DFA21( this, SpecialStateTransition21 );
		dfa26 = new DFA26( this );
		dfa30 = new DFA30( this );
		dfa33 = new DFA33( this );
		dfa57 = new DFA57( this );
		dfa60 = new DFA60( this );
		dfa63 = new DFA63( this );
		dfa90 = new DFA90( this );
		dfa94 = new DFA94( this );
		dfa93 = new DFA93( this );
		dfa106 = new DFA106( this );
		dfa115 = new DFA115( this );
		dfa118 = new DFA118( this );
		dfa121 = new DFA121( this, SpecialStateTransition121 );
		dfa124 = new DFA124( this, SpecialStateTransition124 );
		dfa125 = new DFA125( this, SpecialStateTransition125 );
		dfa127 = new DFA127( this, SpecialStateTransition127 );
		dfa132 = new DFA132( this, SpecialStateTransition132 );
		dfa136 = new DFA136( this, SpecialStateTransition136 );
		dfa142 = new DFA142( this );
		dfa141 = new DFA141( this );
		dfa151 = new DFA151( this );
		dfa156 = new DFA156( this );
		dfa159 = new DFA159( this );
		dfa162 = new DFA162( this );
		dfa165 = new DFA165( this );
		dfa168 = new DFA168( this );
		dfa171 = new DFA171( this );
		dfa174 = new DFA174( this );
		dfa177 = new DFA177( this );
		dfa180 = new DFA180( this );
		dfa183 = new DFA183( this );
		dfa186 = new DFA186( this );
		dfa189 = new DFA189( this );
		dfa192 = new DFA192( this );
		dfa195 = new DFA195( this );
		dfa198 = new DFA198( this );
		dfa201 = new DFA201( this );
		dfa204 = new DFA204( this, SpecialStateTransition204 );
		dfa207 = new DFA207( this );
		dfa218 = new DFA218( this );
		dfa217 = new DFA217( this );
		dfa223 = new DFA223( this );
	}

	private class DFA4 : DFA
	{
		private const string DFA4_eotS =
			"\x4\xFFFF";
		private const string DFA4_eofS =
			"\x2\x2\x2\xFFFF";
		private const string DFA4_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA4_maxS =
			"\x2\x6A\x2\xFFFF";
		private const string DFA4_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA4_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA4_transitionS =
			{
				"\x1\x1\x3\x3\x17\xFFFF\x2\x3\x2\xFFFF\x1\x3\x1\x2\x2\x3\x1\xFFFF\x1"+
				"\x3\x1\xFFFF\x3\x3\x1\xFFFF\x4\x3\x1\xFFFF\x1\x3\x2\xFFFF\x2\x3\x2\xFFFF"+
				"\x2\x3\x1F\xFFFF\x2\x3\x3\xFFFF\xB\x3",
				"\x1\x1\x3\x3\x17\xFFFF\x2\x3\x2\xFFFF\x1\x3\x1\x2\x2\x3\x1\xFFFF\x1"+
				"\x3\x1\xFFFF\x3\x3\x1\xFFFF\x4\x3\x1\xFFFF\x1\x3\x2\xFFFF\x2\x3\x2\xFFFF"+
				"\x2\x3\x1F\xFFFF\x2\x3\x3\xFFFF\xB\x3",
				"",
				""
			};

		private static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
		private static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
		private static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
		private static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
		private static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
		private static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
		private static readonly short[][] DFA4_transition;

		static DFA4()
		{
			int numStates = DFA4_transitionS.Length;
			DFA4_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA4_transition[i] = DFA.UnpackEncodedString(DFA4_transitionS[i]);
			}
		}

		public DFA4( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 4;
			this.eot = DFA4_eot;
			this.eof = DFA4_eof;
			this.min = DFA4_min;
			this.max = DFA4_max;
			this.accept = DFA4_accept;
			this.special = DFA4_special;
			this.transition = DFA4_transition;
		}

		public override string Description { get { return "()* loopback of 23:18: ( ( LT )* sourceElement )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA5 : DFA
	{
		private const string DFA5_eotS =
			"\x18\xFFFF";
		private const string DFA5_eofS =
			"\x18\xFFFF";
		private const string DFA5_minS =
			"\x1\x5\x1\x0\x16\xFFFF";
		private const string DFA5_maxS =
			"\x1\x6A\x1\x0\x16\xFFFF";
		private const string DFA5_acceptS =
			"\x2\xFFFF\x1\x2\x14\xFFFF\x1\x1";
		private const string DFA5_specialS =
			"\x1\xFFFF\x1\x0\x16\xFFFF}>";
		private static readonly string[] DFA5_transitionS =
			{
				"\x3\x2\x17\xFFFF\x1\x1\x1\x2\x2\xFFFF\x1\x2\x1\xFFFF\x2\x2\x1\xFFFF"+
				"\x1\x2\x1\xFFFF\x3\x2\x1\xFFFF\x4\x2\x1\xFFFF\x1\x2\x2\xFFFF\x2\x2\x2"+
				"\xFFFF\x2\x2\x1F\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
		private static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
		private static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
		private static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
		private static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
		private static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
		private static readonly short[][] DFA5_transition;

		static DFA5()
		{
			int numStates = DFA5_transitionS.Length;
			DFA5_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA5_transition[i] = DFA.UnpackEncodedString(DFA5_transitionS[i]);
			}
		}

		public DFA5( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 5;
			this.eot = DFA5_eot;
			this.eof = DFA5_eof;
			this.min = DFA5_min;
			this.max = DFA5_max;
			this.accept = DFA5_accept;
			this.special = DFA5_special;
			this.transition = DFA5_transition;
		}

		public override string Description { get { return "26:1: sourceElement : ( functionDeclaration | statement );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition5(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA5_1 = input.LA(1);


				int index5_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred5_JavaScript_fragment)) ) {s = 23;}

				else if ( (true) ) {s = 2;}


				input.Seek(index5_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 5, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA17 : DFA
	{
		private const string DFA17_eotS =
			"\x4\xFFFF";
		private const string DFA17_eofS =
			"\x4\xFFFF";
		private const string DFA17_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA17_maxS =
			"\x2\x22\x2\xFFFF";
		private const string DFA17_acceptS =
			"\x2\xFFFF\x1\x1\x1\x2";
		private const string DFA17_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA17_transitionS =
			{
				"\x1\x1\x1\x2\x1C\xFFFF\x1\x3",
				"\x1\x1\x1\x2\x1C\xFFFF\x1\x3",
				"",
				""
			};

		private static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
		private static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
		private static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
		private static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
		private static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
		private static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
		private static readonly short[][] DFA17_transition;

		static DFA17()
		{
			int numStates = DFA17_transitionS.Length;
			DFA17_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA17_transition[i] = DFA.UnpackEncodedString(DFA17_transitionS[i]);
			}
		}

		public DFA17( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 17;
			this.eot = DFA17_eot;
			this.eof = DFA17_eof;
			this.min = DFA17_min;
			this.max = DFA17_max;
			this.accept = DFA17_accept;
			this.special = DFA17_special;
			this.transition = DFA17_transition;
		}

		public override string Description { get { return "41:8: ( ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )* )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA16 : DFA
	{
		private const string DFA16_eotS =
			"\x4\xFFFF";
		private const string DFA16_eofS =
			"\x4\xFFFF";
		private const string DFA16_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA16_maxS =
			"\x2\x22\x2\xFFFF";
		private const string DFA16_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA16_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA16_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x3\x1\x2",
				"\x1\x1\x1C\xFFFF\x1\x3\x1\x2",
				"",
				""
			};

		private static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
		private static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
		private static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
		private static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
		private static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
		private static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
		private static readonly short[][] DFA16_transition;

		static DFA16()
		{
			int numStates = DFA16_transitionS.Length;
			DFA16_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA16_transition[i] = DFA.UnpackEncodedString(DFA16_transitionS[i]);
			}
		}

		public DFA16( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 16;
			this.eot = DFA16_eot;
			this.eof = DFA16_eof;
			this.min = DFA16_min;
			this.max = DFA16_max;
			this.accept = DFA16_accept;
			this.special = DFA16_special;
			this.transition = DFA16_transition;
		}

		public override string Description { get { return "()* loopback of 41:25: ( ( LT )* ',' ( LT )* Identifier )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA21 : DFA
	{
		private const string DFA21_eotS =
			"\x19\xFFFF";
		private const string DFA21_eofS =
			"\x19\xFFFF";
		private const string DFA21_minS =
			"\x1\x5\x1\x0\x3\xFFFF\x1\x0\x13\xFFFF";
		private const string DFA21_maxS =
			"\x1\x6A\x1\x0\x3\xFFFF\x1\x0\x13\xFFFF";
		private const string DFA21_acceptS =
			"\x2\xFFFF\x1\x2\x1\x3\x1\x4\x7\xFFFF\x1\x5\x1\x6\x2\xFFFF\x1\x7\x1\x8"+
			"\x1\x9\x1\xA\x1\xC\x1\xD\x1\xE\x1\x1\x1\xB";
		private const string DFA21_specialS =
			"\x1\xFFFF\x1\x0\x3\xFFFF\x1\x1\x13\xFFFF}>";
		private static readonly string[] DFA21_transitionS =
			{
				"\x1\x5\x2\x4\x17\xFFFF\x2\x4\x2\xFFFF\x1\x1\x1\xFFFF\x1\x2\x1\x3\x1"+
				"\xFFFF\x1\xC\x1\xFFFF\x3\xD\x1\xFFFF\x1\x10\x1\x11\x1\x12\x1\x13\x1"+
				"\xFFFF\x1\x14\x2\xFFFF\x1\x15\x1\x16\x2\xFFFF\x2\x4\x1F\xFFFF\x2\x4"+
				"\x3\xFFFF\xB\x4",
				"\x1\xFFFF",
				"",
				"",
				"",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA21_eot = DFA.UnpackEncodedString(DFA21_eotS);
		private static readonly short[] DFA21_eof = DFA.UnpackEncodedString(DFA21_eofS);
		private static readonly char[] DFA21_min = DFA.UnpackEncodedStringToUnsignedChars(DFA21_minS);
		private static readonly char[] DFA21_max = DFA.UnpackEncodedStringToUnsignedChars(DFA21_maxS);
		private static readonly short[] DFA21_accept = DFA.UnpackEncodedString(DFA21_acceptS);
		private static readonly short[] DFA21_special = DFA.UnpackEncodedString(DFA21_specialS);
		private static readonly short[][] DFA21_transition;

		static DFA21()
		{
			int numStates = DFA21_transitionS.Length;
			DFA21_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA21_transition[i] = DFA.UnpackEncodedString(DFA21_transitionS[i]);
			}
		}

		public DFA21( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 21;
			this.eot = DFA21_eot;
			this.eof = DFA21_eof;
			this.min = DFA21_min;
			this.max = DFA21_max;
			this.accept = DFA21_accept;
			this.special = DFA21_special;
			this.transition = DFA21_transition;
		}

		public override string Description { get { return "49:1: statement : ( statementBlock | variableStatement | emptyStatement | expressionStatement | ifStatement | iterationStatement | continueStatement | breakStatement | returnStatement | withStatement | labelledStatement | switchStatement | throwStatement | tryStatement );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition21(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA21_1 = input.LA(1);


				int index21_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred21_JavaScript_fragment)) ) {s = 23;}

				else if ( (EvaluatePredicate(synpred24_JavaScript_fragment)) ) {s = 4;}


				input.Seek(index21_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA21_5 = input.LA(1);


				int index21_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred24_JavaScript_fragment)) ) {s = 4;}

				else if ( (EvaluatePredicate(synpred31_JavaScript_fragment)) ) {s = 24;}


				input.Seek(index21_5);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 21, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA26 : DFA
	{
		private const string DFA26_eotS =
			"\x4\xFFFF";
		private const string DFA26_eofS =
			"\x1\x2\x3\xFFFF";
		private const string DFA26_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA26_maxS =
			"\x2\x6A\x2\xFFFF";
		private const string DFA26_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA26_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA26_transitionS =
			{
				"\x1\x1\x3\x3\x17\xFFFF\x2\x3\x2\xFFFF\x1\x3\x1\x2\x2\x3\x1\xFFFF\x1"+
				"\x3\x1\xFFFF\x3\x3\x1\xFFFF\x4\x3\x1\xFFFF\x1\x3\x2\x2\x2\x3\x2\xFFFF"+
				"\x2\x3\x1F\xFFFF\x2\x3\x3\xFFFF\xB\x3",
				"\x1\x1\x3\x3\x17\xFFFF\x2\x3\x2\xFFFF\x1\x3\x1\x2\x2\x3\x1\xFFFF\x1"+
				"\x3\x1\xFFFF\x3\x3\x1\xFFFF\x4\x3\x1\xFFFF\x1\x3\x2\x2\x2\x3\x2\xFFFF"+
				"\x2\x3\x1F\xFFFF\x2\x3\x3\xFFFF\xB\x3",
				"",
				""
			};

		private static readonly short[] DFA26_eot = DFA.UnpackEncodedString(DFA26_eotS);
		private static readonly short[] DFA26_eof = DFA.UnpackEncodedString(DFA26_eofS);
		private static readonly char[] DFA26_min = DFA.UnpackEncodedStringToUnsignedChars(DFA26_minS);
		private static readonly char[] DFA26_max = DFA.UnpackEncodedStringToUnsignedChars(DFA26_maxS);
		private static readonly short[] DFA26_accept = DFA.UnpackEncodedString(DFA26_acceptS);
		private static readonly short[] DFA26_special = DFA.UnpackEncodedString(DFA26_specialS);
		private static readonly short[][] DFA26_transition;

		static DFA26()
		{
			int numStates = DFA26_transitionS.Length;
			DFA26_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA26_transition[i] = DFA.UnpackEncodedString(DFA26_transitionS[i]);
			}
		}

		public DFA26( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 26;
			this.eot = DFA26_eot;
			this.eof = DFA26_eof;
			this.min = DFA26_min;
			this.max = DFA26_max;
			this.accept = DFA26_accept;
			this.special = DFA26_special;
			this.transition = DFA26_transition;
		}

		public override string Description { get { return "()* loopback of 71:14: ( ( LT )* statement )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA30 : DFA
	{
		private const string DFA30_eotS =
			"\x5\xFFFF";
		private const string DFA30_eofS =
			"\x1\xFFFF\x1\x2\x2\xFFFF\x1\x2";
		private const string DFA30_minS =
			"\x2\x4\x2\xFFFF\x1\x4";
		private const string DFA30_maxS =
			"\x1\x26\x1\x6A\x2\xFFFF\x1\x6A";
		private const string DFA30_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1\x1\xFFFF";
		private const string DFA30_specialS =
			"\x5\xFFFF}>";
		private static readonly string[] DFA30_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x3\x4\xFFFF\x1\x2",
				"\x1\x4\x3\x2\x17\xFFFF\x2\x2\x1\x3\x1\xFFFF\x4\x2\x1\xFFFF\x5\x2\x1"+
				"\xFFFF\x4\x2\x1\xFFFF\x5\x2\x2\xFFFF\x2\x2\x1F\xFFFF\x2\x2\x3\xFFFF"+
				"\xB\x2",
				"",
				"",
				"\x1\x4\x3\x2\x17\xFFFF\x2\x2\x1\x3\x1\xFFFF\x4\x2\x1\xFFFF\x5\x2\x1"+
				"\xFFFF\x4\x2\x1\xFFFF\x5\x2\x2\xFFFF\x2\x2\x1F\xFFFF\x2\x2\x3\xFFFF"+
				"\xB\x2"
			};

		private static readonly short[] DFA30_eot = DFA.UnpackEncodedString(DFA30_eotS);
		private static readonly short[] DFA30_eof = DFA.UnpackEncodedString(DFA30_eofS);
		private static readonly char[] DFA30_min = DFA.UnpackEncodedStringToUnsignedChars(DFA30_minS);
		private static readonly char[] DFA30_max = DFA.UnpackEncodedStringToUnsignedChars(DFA30_maxS);
		private static readonly short[] DFA30_accept = DFA.UnpackEncodedString(DFA30_acceptS);
		private static readonly short[] DFA30_special = DFA.UnpackEncodedString(DFA30_specialS);
		private static readonly short[][] DFA30_transition;

		static DFA30()
		{
			int numStates = DFA30_transitionS.Length;
			DFA30_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA30_transition[i] = DFA.UnpackEncodedString(DFA30_transitionS[i]);
			}
		}

		public DFA30( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 30;
			this.eot = DFA30_eot;
			this.eof = DFA30_eof;
			this.min = DFA30_min;
			this.max = DFA30_max;
			this.accept = DFA30_accept;
			this.special = DFA30_special;
			this.transition = DFA30_transition;
		}

		public override string Description { get { return "()* loopback of 79:24: ( ( LT )* ',' ( LT )* variableDeclaration )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA33 : DFA
	{
		private const string DFA33_eotS =
			"\x4\xFFFF";
		private const string DFA33_eofS =
			"\x1\x2\x3\xFFFF";
		private const string DFA33_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA33_maxS =
			"\x2\x26\x2\xFFFF";
		private const string DFA33_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA33_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA33_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x3\x4\xFFFF\x1\x2",
				"\x1\x1\x1C\xFFFF\x1\x3\x4\xFFFF\x1\x2",
				"",
				""
			};

		private static readonly short[] DFA33_eot = DFA.UnpackEncodedString(DFA33_eotS);
		private static readonly short[] DFA33_eof = DFA.UnpackEncodedString(DFA33_eofS);
		private static readonly char[] DFA33_min = DFA.UnpackEncodedStringToUnsignedChars(DFA33_minS);
		private static readonly char[] DFA33_max = DFA.UnpackEncodedStringToUnsignedChars(DFA33_maxS);
		private static readonly short[] DFA33_accept = DFA.UnpackEncodedString(DFA33_acceptS);
		private static readonly short[] DFA33_special = DFA.UnpackEncodedString(DFA33_specialS);
		private static readonly short[][] DFA33_transition;

		static DFA33()
		{
			int numStates = DFA33_transitionS.Length;
			DFA33_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA33_transition[i] = DFA.UnpackEncodedString(DFA33_transitionS[i]);
			}
		}

		public DFA33( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 33;
			this.eot = DFA33_eot;
			this.eof = DFA33_eof;
			this.min = DFA33_min;
			this.max = DFA33_max;
			this.accept = DFA33_accept;
			this.special = DFA33_special;
			this.transition = DFA33_transition;
		}

		public override string Description { get { return "()* loopback of 83:28: ( ( LT )* ',' ( LT )* variableDeclarationNoIn )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA57 : DFA
	{
		private const string DFA57_eotS =
			"\x4\xFFFF";
		private const string DFA57_eofS =
			"\x4\xFFFF";
		private const string DFA57_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA57_maxS =
			"\x2\x6A\x2\xFFFF";
		private const string DFA57_acceptS =
			"\x2\xFFFF\x1\x1\x1\x2";
		private const string DFA57_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA57_transitionS =
			{
				"\x1\x1\x3\x2\x17\xFFFF\x2\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x3\x13"+
				"\xFFFF\x2\x2\x1F\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"\x1\x1\x3\x2\x17\xFFFF\x2\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x3\x13"+
				"\xFFFF\x2\x2\x1F\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"",
				""
			};

		private static readonly short[] DFA57_eot = DFA.UnpackEncodedString(DFA57_eotS);
		private static readonly short[] DFA57_eof = DFA.UnpackEncodedString(DFA57_eofS);
		private static readonly char[] DFA57_min = DFA.UnpackEncodedStringToUnsignedChars(DFA57_minS);
		private static readonly char[] DFA57_max = DFA.UnpackEncodedStringToUnsignedChars(DFA57_maxS);
		private static readonly short[] DFA57_accept = DFA.UnpackEncodedString(DFA57_acceptS);
		private static readonly short[] DFA57_special = DFA.UnpackEncodedString(DFA57_specialS);
		private static readonly short[][] DFA57_transition;

		static DFA57()
		{
			int numStates = DFA57_transitionS.Length;
			DFA57_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA57_transition[i] = DFA.UnpackEncodedString(DFA57_transitionS[i]);
			}
		}

		public DFA57( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 57;
			this.eot = DFA57_eot;
			this.eof = DFA57_eof;
			this.min = DFA57_min;
			this.max = DFA57_max;
			this.accept = DFA57_accept;
			this.special = DFA57_special;
			this.transition = DFA57_transition;
		}

		public override string Description { get { return "130:19: ( ( LT )* forStatementInitialiserPart )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA60 : DFA
	{
		private const string DFA60_eotS =
			"\x4\xFFFF";
		private const string DFA60_eofS =
			"\x4\xFFFF";
		private const string DFA60_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA60_maxS =
			"\x2\x6A\x2\xFFFF";
		private const string DFA60_acceptS =
			"\x2\xFFFF\x1\x1\x1\x2";
		private const string DFA60_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA60_transitionS =
			{
				"\x1\x1\x3\x2\x17\xFFFF\x2\x2\x2\xFFFF\x1\x2\x2\xFFFF\x1\x3\x13\xFFFF"+
				"\x2\x2\x1F\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"\x1\x1\x3\x2\x17\xFFFF\x2\x2\x2\xFFFF\x1\x2\x2\xFFFF\x1\x3\x13\xFFFF"+
				"\x2\x2\x1F\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"",
				""
			};

		private static readonly short[] DFA60_eot = DFA.UnpackEncodedString(DFA60_eotS);
		private static readonly short[] DFA60_eof = DFA.UnpackEncodedString(DFA60_eofS);
		private static readonly char[] DFA60_min = DFA.UnpackEncodedStringToUnsignedChars(DFA60_minS);
		private static readonly char[] DFA60_max = DFA.UnpackEncodedStringToUnsignedChars(DFA60_maxS);
		private static readonly short[] DFA60_accept = DFA.UnpackEncodedString(DFA60_acceptS);
		private static readonly short[] DFA60_special = DFA.UnpackEncodedString(DFA60_specialS);
		private static readonly short[][] DFA60_transition;

		static DFA60()
		{
			int numStates = DFA60_transitionS.Length;
			DFA60_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA60_transition[i] = DFA.UnpackEncodedString(DFA60_transitionS[i]);
			}
		}

		public DFA60( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 60;
			this.eot = DFA60_eot;
			this.eof = DFA60_eof;
			this.min = DFA60_min;
			this.max = DFA60_max;
			this.accept = DFA60_accept;
			this.special = DFA60_special;
			this.transition = DFA60_transition;
		}

		public override string Description { get { return "130:64: ( ( LT )* expression )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA63 : DFA
	{
		private const string DFA63_eotS =
			"\x4\xFFFF";
		private const string DFA63_eofS =
			"\x4\xFFFF";
		private const string DFA63_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA63_maxS =
			"\x2\x6A\x2\xFFFF";
		private const string DFA63_acceptS =
			"\x2\xFFFF\x1\x1\x1\x2";
		private const string DFA63_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA63_transitionS =
			{
				"\x1\x1\x3\x2\x17\xFFFF\x2\x2\x1\xFFFF\x1\x3\x1\x2\x16\xFFFF\x2\x2\x1F"+
				"\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"\x1\x1\x3\x2\x17\xFFFF\x2\x2\x1\xFFFF\x1\x3\x1\x2\x16\xFFFF\x2\x2"+
				"\x1F\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"",
				""
			};

		private static readonly short[] DFA63_eot = DFA.UnpackEncodedString(DFA63_eotS);
		private static readonly short[] DFA63_eof = DFA.UnpackEncodedString(DFA63_eofS);
		private static readonly char[] DFA63_min = DFA.UnpackEncodedStringToUnsignedChars(DFA63_minS);
		private static readonly char[] DFA63_max = DFA.UnpackEncodedStringToUnsignedChars(DFA63_maxS);
		private static readonly short[] DFA63_accept = DFA.UnpackEncodedString(DFA63_acceptS);
		private static readonly short[] DFA63_special = DFA.UnpackEncodedString(DFA63_specialS);
		private static readonly short[][] DFA63_transition;

		static DFA63()
		{
			int numStates = DFA63_transitionS.Length;
			DFA63_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA63_transition[i] = DFA.UnpackEncodedString(DFA63_transitionS[i]);
			}
		}

		public DFA63( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 63;
			this.eot = DFA63_eot;
			this.eof = DFA63_eof;
			this.min = DFA63_min;
			this.max = DFA63_max;
			this.accept = DFA63_accept;
			this.special = DFA63_special;
			this.transition = DFA63_transition;
		}

		public override string Description { get { return "130:92: ( ( LT )* expression )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA90 : DFA
	{
		private const string DFA90_eotS =
			"\x4\xFFFF";
		private const string DFA90_eofS =
			"\x4\xFFFF";
		private const string DFA90_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA90_maxS =
			"\x2\x35\x2\xFFFF";
		private const string DFA90_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA90_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA90_transitionS =
			{
				"\x1\x1\x1F\xFFFF\x1\x2\xF\xFFFF\x1\x3\x1\x2",
				"\x1\x1\x1F\xFFFF\x1\x2\xF\xFFFF\x1\x3\x1\x2",
				"",
				""
			};

		private static readonly short[] DFA90_eot = DFA.UnpackEncodedString(DFA90_eotS);
		private static readonly short[] DFA90_eof = DFA.UnpackEncodedString(DFA90_eofS);
		private static readonly char[] DFA90_min = DFA.UnpackEncodedStringToUnsignedChars(DFA90_minS);
		private static readonly char[] DFA90_max = DFA.UnpackEncodedStringToUnsignedChars(DFA90_maxS);
		private static readonly short[] DFA90_accept = DFA.UnpackEncodedString(DFA90_acceptS);
		private static readonly short[] DFA90_special = DFA.UnpackEncodedString(DFA90_specialS);
		private static readonly short[][] DFA90_transition;

		static DFA90()
		{
			int numStates = DFA90_transitionS.Length;
			DFA90_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA90_transition[i] = DFA.UnpackEncodedString(DFA90_transitionS[i]);
			}
		}

		public DFA90( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 90;
			this.eot = DFA90_eot;
			this.eof = DFA90_eof;
			this.min = DFA90_min;
			this.max = DFA90_max;
			this.accept = DFA90_accept;
			this.special = DFA90_special;
			this.transition = DFA90_transition;
		}

		public override string Description { get { return "()* loopback of 172:8: ( ( LT )* caseClause )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA94 : DFA
	{
		private const string DFA94_eotS =
			"\x4\xFFFF";
		private const string DFA94_eofS =
			"\x4\xFFFF";
		private const string DFA94_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA94_maxS =
			"\x2\x35\x2\xFFFF";
		private const string DFA94_acceptS =
			"\x2\xFFFF\x1\x1\x1\x2";
		private const string DFA94_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA94_transitionS =
			{
				"\x1\x1\x1F\xFFFF\x1\x3\x10\xFFFF\x1\x2",
				"\x1\x1\x1F\xFFFF\x1\x3\x10\xFFFF\x1\x2",
				"",
				""
			};

		private static readonly short[] DFA94_eot = DFA.UnpackEncodedString(DFA94_eotS);
		private static readonly short[] DFA94_eof = DFA.UnpackEncodedString(DFA94_eofS);
		private static readonly char[] DFA94_min = DFA.UnpackEncodedStringToUnsignedChars(DFA94_minS);
		private static readonly char[] DFA94_max = DFA.UnpackEncodedStringToUnsignedChars(DFA94_maxS);
		private static readonly short[] DFA94_accept = DFA.UnpackEncodedString(DFA94_acceptS);
		private static readonly short[] DFA94_special = DFA.UnpackEncodedString(DFA94_specialS);
		private static readonly short[][] DFA94_transition;

		static DFA94()
		{
			int numStates = DFA94_transitionS.Length;
			DFA94_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA94_transition[i] = DFA.UnpackEncodedString(DFA94_transitionS[i]);
			}
		}

		public DFA94( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 94;
			this.eot = DFA94_eot;
			this.eof = DFA94_eof;
			this.min = DFA94_min;
			this.max = DFA94_max;
			this.accept = DFA94_accept;
			this.special = DFA94_special;
			this.transition = DFA94_transition;
		}

		public override string Description { get { return "172:27: ( ( LT )* defaultClause ( ( LT )* caseClause )* )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA93 : DFA
	{
		private const string DFA93_eotS =
			"\x4\xFFFF";
		private const string DFA93_eofS =
			"\x4\xFFFF";
		private const string DFA93_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA93_maxS =
			"\x2\x34\x2\xFFFF";
		private const string DFA93_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA93_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA93_transitionS =
			{
				"\x1\x1\x1F\xFFFF\x1\x2\xF\xFFFF\x1\x3",
				"\x1\x1\x1F\xFFFF\x1\x2\xF\xFFFF\x1\x3",
				"",
				""
			};

		private static readonly short[] DFA93_eot = DFA.UnpackEncodedString(DFA93_eotS);
		private static readonly short[] DFA93_eof = DFA.UnpackEncodedString(DFA93_eofS);
		private static readonly char[] DFA93_min = DFA.UnpackEncodedStringToUnsignedChars(DFA93_minS);
		private static readonly char[] DFA93_max = DFA.UnpackEncodedStringToUnsignedChars(DFA93_maxS);
		private static readonly short[] DFA93_accept = DFA.UnpackEncodedString(DFA93_acceptS);
		private static readonly short[] DFA93_special = DFA.UnpackEncodedString(DFA93_specialS);
		private static readonly short[][] DFA93_transition;

		static DFA93()
		{
			int numStates = DFA93_transitionS.Length;
			DFA93_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA93_transition[i] = DFA.UnpackEncodedString(DFA93_transitionS[i]);
			}
		}

		public DFA93( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 93;
			this.eot = DFA93_eot;
			this.eof = DFA93_eof;
			this.min = DFA93_min;
			this.max = DFA93_max;
			this.accept = DFA93_accept;
			this.special = DFA93_special;
			this.transition = DFA93_transition;
		}

		public override string Description { get { return "()* loopback of 172:47: ( ( LT )* caseClause )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA106 : DFA
	{
		private const string DFA106_eotS =
			"\x4\xFFFF";
		private const string DFA106_eofS =
			"\x2\x3\x2\xFFFF";
		private const string DFA106_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA106_maxS =
			"\x2\x6A\x2\xFFFF";
		private const string DFA106_acceptS =
			"\x2\xFFFF\x1\x1\x1\x2";
		private const string DFA106_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA106_transitionS =
			{
				"\x1\x1\x3\x3\x17\xFFFF\x2\x3\x2\xFFFF\x4\x3\x1\xFFFF\x5\x3\x1\xFFFF"+
				"\x4\x3\x1\xFFFF\x5\x3\x1\xFFFF\x1\x2\x2\x3\x1F\xFFFF\x2\x3\x3\xFFFF"+
				"\xB\x3",
				"\x1\x1\x3\x3\x17\xFFFF\x2\x3\x2\xFFFF\x4\x3\x1\xFFFF\x5\x3\x1\xFFFF"+
				"\x4\x3\x1\xFFFF\x5\x3\x1\xFFFF\x1\x2\x2\x3\x1F\xFFFF\x2\x3\x3\xFFFF"+
				"\xB\x3",
				"",
				""
			};

		private static readonly short[] DFA106_eot = DFA.UnpackEncodedString(DFA106_eotS);
		private static readonly short[] DFA106_eof = DFA.UnpackEncodedString(DFA106_eofS);
		private static readonly char[] DFA106_min = DFA.UnpackEncodedStringToUnsignedChars(DFA106_minS);
		private static readonly char[] DFA106_max = DFA.UnpackEncodedStringToUnsignedChars(DFA106_maxS);
		private static readonly short[] DFA106_accept = DFA.UnpackEncodedString(DFA106_acceptS);
		private static readonly short[] DFA106_special = DFA.UnpackEncodedString(DFA106_specialS);
		private static readonly short[][] DFA106_transition;

		static DFA106()
		{
			int numStates = DFA106_transitionS.Length;
			DFA106_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA106_transition[i] = DFA.UnpackEncodedString(DFA106_transitionS[i]);
			}
		}

		public DFA106( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 106;
			this.eot = DFA106_eot;
			this.eof = DFA106_eof;
			this.min = DFA106_min;
			this.max = DFA106_max;
			this.accept = DFA106_accept;
			this.special = DFA106_special;
			this.transition = DFA106_transition;
		}

		public override string Description { get { return "188:64: ( ( LT )* finallyClause )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA115 : DFA
	{
		private const string DFA115_eotS =
			"\x5\xFFFF";
		private const string DFA115_eofS =
			"\x2\x2\x2\xFFFF\x1\x2";
		private const string DFA115_minS =
			"\x2\x4\x2\xFFFF\x1\x4";
		private const string DFA115_maxS =
			"\x1\x3C\x1\x6A\x2\xFFFF\x1\x6A";
		private const string DFA115_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1\x1\xFFFF";
		private const string DFA115_specialS =
			"\x5\xFFFF}>";
		private static readonly string[] DFA115_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x3\x1\x2\x3\xFFFF\x1\x2\xB\xFFFF\x1\x2\x9\xFFFF"+
				"\x1\x2",
				"\x1\x4\x3\x2\x17\xFFFF\x2\x2\x1\x3\x5\x2\x1\xFFFF\x5\x2\x1\xFFFF\xA"+
				"\x2\x2\xFFFF\x3\x2\x1E\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"",
				"",
				"\x1\x4\x3\x2\x17\xFFFF\x2\x2\x1\x3\x5\x2\x1\xFFFF\x5\x2\x1\xFFFF\xA"+
				"\x2\x2\xFFFF\x3\x2\x1E\xFFFF\x2\x2\x3\xFFFF\xB\x2"
			};

		private static readonly short[] DFA115_eot = DFA.UnpackEncodedString(DFA115_eotS);
		private static readonly short[] DFA115_eof = DFA.UnpackEncodedString(DFA115_eofS);
		private static readonly char[] DFA115_min = DFA.UnpackEncodedStringToUnsignedChars(DFA115_minS);
		private static readonly char[] DFA115_max = DFA.UnpackEncodedStringToUnsignedChars(DFA115_maxS);
		private static readonly short[] DFA115_accept = DFA.UnpackEncodedString(DFA115_acceptS);
		private static readonly short[] DFA115_special = DFA.UnpackEncodedString(DFA115_specialS);
		private static readonly short[][] DFA115_transition;

		static DFA115()
		{
			int numStates = DFA115_transitionS.Length;
			DFA115_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA115_transition[i] = DFA.UnpackEncodedString(DFA115_transitionS[i]);
			}
		}

		public DFA115( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 115;
			this.eot = DFA115_eot;
			this.eof = DFA115_eof;
			this.min = DFA115_min;
			this.max = DFA115_max;
			this.accept = DFA115_accept;
			this.special = DFA115_special;
			this.transition = DFA115_transition;
		}

		public override string Description { get { return "()* loopback of 201:25: ( ( LT )* ',' ( LT )* assignmentExpression )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA118 : DFA
	{
		private const string DFA118_eotS =
			"\x4\xFFFF";
		private const string DFA118_eofS =
			"\x1\x2\x3\xFFFF";
		private const string DFA118_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA118_maxS =
			"\x2\x26\x2\xFFFF";
		private const string DFA118_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA118_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA118_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x3\x4\xFFFF\x1\x2",
				"\x1\x1\x1C\xFFFF\x1\x3\x4\xFFFF\x1\x2",
				"",
				""
			};

		private static readonly short[] DFA118_eot = DFA.UnpackEncodedString(DFA118_eotS);
		private static readonly short[] DFA118_eof = DFA.UnpackEncodedString(DFA118_eofS);
		private static readonly char[] DFA118_min = DFA.UnpackEncodedStringToUnsignedChars(DFA118_minS);
		private static readonly char[] DFA118_max = DFA.UnpackEncodedStringToUnsignedChars(DFA118_maxS);
		private static readonly short[] DFA118_accept = DFA.UnpackEncodedString(DFA118_acceptS);
		private static readonly short[] DFA118_special = DFA.UnpackEncodedString(DFA118_specialS);
		private static readonly short[][] DFA118_transition;

		static DFA118()
		{
			int numStates = DFA118_transitionS.Length;
			DFA118_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA118_transition[i] = DFA.UnpackEncodedString(DFA118_transitionS[i]);
			}
		}

		public DFA118( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 118;
			this.eot = DFA118_eot;
			this.eof = DFA118_eof;
			this.min = DFA118_min;
			this.max = DFA118_max;
			this.accept = DFA118_accept;
			this.special = DFA118_special;
			this.transition = DFA118_transition;
		}

		public override string Description { get { return "()* loopback of 205:29: ( ( LT )* ',' ( LT )* assignmentExpressionNoIn )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA121 : DFA
	{
		private const string DFA121_eotS =
			"\xB\xFFFF";
		private const string DFA121_eofS =
			"\xB\xFFFF";
		private const string DFA121_minS =
			"\x1\x5\x8\x0\x2\xFFFF";
		private const string DFA121_maxS =
			"\x1\x6A\x8\x0\x2\xFFFF";
		private const string DFA121_acceptS =
			"\x9\xFFFF\x1\x1\x1\x2";
		private const string DFA121_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x2\xFFFF}>";
		private static readonly string[] DFA121_transitionS =
			{
				"\x1\x2\x2\x3\x17\xFFFF\x1\x7\x1\x6\x2\xFFFF\x1\x5\x16\xFFFF\x1\x8\x1"+
				"\x4\x1F\xFFFF\x2\x9\x3\xFFFF\x7\x9\x1\x1\x3\x3",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"",
				""
			};

		private static readonly short[] DFA121_eot = DFA.UnpackEncodedString(DFA121_eotS);
		private static readonly short[] DFA121_eof = DFA.UnpackEncodedString(DFA121_eofS);
		private static readonly char[] DFA121_min = DFA.UnpackEncodedStringToUnsignedChars(DFA121_minS);
		private static readonly char[] DFA121_max = DFA.UnpackEncodedStringToUnsignedChars(DFA121_maxS);
		private static readonly short[] DFA121_accept = DFA.UnpackEncodedString(DFA121_acceptS);
		private static readonly short[] DFA121_special = DFA.UnpackEncodedString(DFA121_specialS);
		private static readonly short[][] DFA121_transition;

		static DFA121()
		{
			int numStates = DFA121_transitionS.Length;
			DFA121_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA121_transition[i] = DFA.UnpackEncodedString(DFA121_transitionS[i]);
			}
		}

		public DFA121( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 121;
			this.eot = DFA121_eot;
			this.eof = DFA121_eof;
			this.min = DFA121_min;
			this.max = DFA121_max;
			this.accept = DFA121_accept;
			this.special = DFA121_special;
			this.transition = DFA121_transition;
		}

		public override string Description { get { return "208:1: assignmentExpression : ( conditionalExpression | leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpression );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition121(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA121_1 = input.LA(1);


				int index121_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred140_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index121_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA121_2 = input.LA(1);


				int index121_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred140_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index121_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA121_3 = input.LA(1);


				int index121_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred140_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index121_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA121_4 = input.LA(1);


				int index121_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred140_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index121_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA121_5 = input.LA(1);


				int index121_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred140_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index121_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA121_6 = input.LA(1);


				int index121_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred140_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index121_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA121_7 = input.LA(1);


				int index121_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred140_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index121_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA121_8 = input.LA(1);


				int index121_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred140_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index121_8);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 121, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA124 : DFA
	{
		private const string DFA124_eotS =
			"\xB\xFFFF";
		private const string DFA124_eofS =
			"\xB\xFFFF";
		private const string DFA124_minS =
			"\x1\x5\x8\x0\x2\xFFFF";
		private const string DFA124_maxS =
			"\x1\x6A\x8\x0\x2\xFFFF";
		private const string DFA124_acceptS =
			"\x9\xFFFF\x1\x1\x1\x2";
		private const string DFA124_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x2\xFFFF}>";
		private static readonly string[] DFA124_transitionS =
			{
				"\x1\x2\x2\x3\x17\xFFFF\x1\x7\x1\x6\x2\xFFFF\x1\x5\x16\xFFFF\x1\x8\x1"+
				"\x4\x1F\xFFFF\x2\x9\x3\xFFFF\x7\x9\x1\x1\x3\x3",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"",
				""
			};

		private static readonly short[] DFA124_eot = DFA.UnpackEncodedString(DFA124_eotS);
		private static readonly short[] DFA124_eof = DFA.UnpackEncodedString(DFA124_eofS);
		private static readonly char[] DFA124_min = DFA.UnpackEncodedStringToUnsignedChars(DFA124_minS);
		private static readonly char[] DFA124_max = DFA.UnpackEncodedStringToUnsignedChars(DFA124_maxS);
		private static readonly short[] DFA124_accept = DFA.UnpackEncodedString(DFA124_acceptS);
		private static readonly short[] DFA124_special = DFA.UnpackEncodedString(DFA124_specialS);
		private static readonly short[][] DFA124_transition;

		static DFA124()
		{
			int numStates = DFA124_transitionS.Length;
			DFA124_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA124_transition[i] = DFA.UnpackEncodedString(DFA124_transitionS[i]);
			}
		}

		public DFA124( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 124;
			this.eot = DFA124_eot;
			this.eof = DFA124_eof;
			this.min = DFA124_min;
			this.max = DFA124_max;
			this.accept = DFA124_accept;
			this.special = DFA124_special;
			this.transition = DFA124_transition;
		}

		public override string Description { get { return "213:1: assignmentExpressionNoIn : ( conditionalExpressionNoIn | leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpressionNoIn );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition124(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA124_1 = input.LA(1);


				int index124_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred143_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index124_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA124_2 = input.LA(1);


				int index124_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred143_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index124_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA124_3 = input.LA(1);


				int index124_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred143_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index124_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA124_4 = input.LA(1);


				int index124_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred143_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index124_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA124_5 = input.LA(1);


				int index124_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred143_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index124_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA124_6 = input.LA(1);


				int index124_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred143_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index124_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA124_7 = input.LA(1);


				int index124_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred143_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index124_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA124_8 = input.LA(1);


				int index124_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred143_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index124_8);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 124, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA125 : DFA
	{
		private const string DFA125_eotS =
			"\xB\xFFFF";
		private const string DFA125_eofS =
			"\xB\xFFFF";
		private const string DFA125_minS =
			"\x1\x5\x8\x0\x2\xFFFF";
		private const string DFA125_maxS =
			"\x1\x6A\x8\x0\x2\xFFFF";
		private const string DFA125_acceptS =
			"\x9\xFFFF\x1\x1\x1\x2";
		private const string DFA125_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x2\xFFFF}>";
		private static readonly string[] DFA125_transitionS =
			{
				"\x1\x2\x2\x3\x17\xFFFF\x1\x7\x1\x6\x2\xFFFF\x1\x5\x16\xFFFF\x1\x8\x1"+
				"\x4\x2B\xFFFF\x1\x1\x3\x3",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"",
				""
			};

		private static readonly short[] DFA125_eot = DFA.UnpackEncodedString(DFA125_eotS);
		private static readonly short[] DFA125_eof = DFA.UnpackEncodedString(DFA125_eofS);
		private static readonly char[] DFA125_min = DFA.UnpackEncodedStringToUnsignedChars(DFA125_minS);
		private static readonly char[] DFA125_max = DFA.UnpackEncodedStringToUnsignedChars(DFA125_maxS);
		private static readonly short[] DFA125_accept = DFA.UnpackEncodedString(DFA125_acceptS);
		private static readonly short[] DFA125_special = DFA.UnpackEncodedString(DFA125_specialS);
		private static readonly short[][] DFA125_transition;

		static DFA125()
		{
			int numStates = DFA125_transitionS.Length;
			DFA125_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA125_transition[i] = DFA.UnpackEncodedString(DFA125_transitionS[i]);
			}
		}

		public DFA125( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 125;
			this.eot = DFA125_eot;
			this.eof = DFA125_eof;
			this.min = DFA125_min;
			this.max = DFA125_max;
			this.accept = DFA125_accept;
			this.special = DFA125_special;
			this.transition = DFA125_transition;
		}

		public override string Description { get { return "218:1: leftHandSideExpression : ( callExpression | newExpression );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition125(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA125_1 = input.LA(1);


				int index125_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred146_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index125_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA125_2 = input.LA(1);


				int index125_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred146_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index125_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA125_3 = input.LA(1);


				int index125_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred146_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index125_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA125_4 = input.LA(1);


				int index125_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred146_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index125_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA125_5 = input.LA(1);


				int index125_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred146_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index125_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA125_6 = input.LA(1);


				int index125_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred146_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index125_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA125_7 = input.LA(1);


				int index125_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred146_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index125_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA125_8 = input.LA(1);


				int index125_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred146_JavaScript_fragment)) ) {s = 9;}

				else if ( (true) ) {s = 10;}


				input.Seek(index125_8);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 125, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA127 : DFA
	{
		private const string DFA127_eotS =
			"\xA\xFFFF";
		private const string DFA127_eofS =
			"\xA\xFFFF";
		private const string DFA127_minS =
			"\x1\x5\x7\xFFFF\x1\x0\x1\xFFFF";
		private const string DFA127_maxS =
			"\x1\x6A\x7\xFFFF\x1\x0\x1\xFFFF";
		private const string DFA127_acceptS =
			"\x1\xFFFF\x1\x1\x7\xFFFF\x1\x2";
		private const string DFA127_specialS =
			"\x8\xFFFF\x1\x0\x1\xFFFF}>";
		private static readonly string[] DFA127_transitionS =
			{
				"\x3\x1\x17\xFFFF\x2\x1\x2\xFFFF\x1\x1\x16\xFFFF\x1\x8\x1\x1\x2B\xFFFF"+
				"\x4\x1",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\xFFFF",
				""
			};

		private static readonly short[] DFA127_eot = DFA.UnpackEncodedString(DFA127_eotS);
		private static readonly short[] DFA127_eof = DFA.UnpackEncodedString(DFA127_eofS);
		private static readonly char[] DFA127_min = DFA.UnpackEncodedStringToUnsignedChars(DFA127_minS);
		private static readonly char[] DFA127_max = DFA.UnpackEncodedStringToUnsignedChars(DFA127_maxS);
		private static readonly short[] DFA127_accept = DFA.UnpackEncodedString(DFA127_acceptS);
		private static readonly short[] DFA127_special = DFA.UnpackEncodedString(DFA127_specialS);
		private static readonly short[][] DFA127_transition;

		static DFA127()
		{
			int numStates = DFA127_transitionS.Length;
			DFA127_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA127_transition[i] = DFA.UnpackEncodedString(DFA127_transitionS[i]);
			}
		}

		public DFA127( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 127;
			this.eot = DFA127_eot;
			this.eof = DFA127_eof;
			this.min = DFA127_min;
			this.max = DFA127_max;
			this.accept = DFA127_accept;
			this.special = DFA127_special;
			this.transition = DFA127_transition;
		}

		public override string Description { get { return "223:1: newExpression : ( memberExpression | 'new' ( LT )* newExpression );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition127(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA127_8 = input.LA(1);


				int index127_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred147_JavaScript_fragment)) ) {s = 1;}

				else if ( (true) ) {s = 9;}


				input.Seek(index127_8);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 127, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA132 : DFA
	{
		private const string DFA132_eotS =
			"\x1A\xFFFF";
		private const string DFA132_eofS =
			"\x1\x2\x19\xFFFF";
		private const string DFA132_minS =
			"\x1\x4\x1\x0\x18\xFFFF";
		private const string DFA132_maxS =
			"\x1\x64\x1\x0\x18\xFFFF";
		private const string DFA132_acceptS =
			"\x2\xFFFF\x1\x2\x15\xFFFF\x1\x1\x1\xFFFF";
		private const string DFA132_specialS =
			"\x1\xFFFF\x1\x0\x18\xFFFF}>";
		private static readonly string[] DFA132_transitionS =
			{
				"\x1\x1\x1B\xFFFF\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x5\xFFFF\x1\x2"+
				"\x4\xFFFF\x1\x2\x8\xFFFF\x1\x18\x1\x2\x1\x18\x22\x2\x3\xFFFF\x2\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA132_eot = DFA.UnpackEncodedString(DFA132_eotS);
		private static readonly short[] DFA132_eof = DFA.UnpackEncodedString(DFA132_eofS);
		private static readonly char[] DFA132_min = DFA.UnpackEncodedStringToUnsignedChars(DFA132_minS);
		private static readonly char[] DFA132_max = DFA.UnpackEncodedStringToUnsignedChars(DFA132_maxS);
		private static readonly short[] DFA132_accept = DFA.UnpackEncodedString(DFA132_acceptS);
		private static readonly short[] DFA132_special = DFA.UnpackEncodedString(DFA132_specialS);
		private static readonly short[][] DFA132_transition;

		static DFA132()
		{
			int numStates = DFA132_transitionS.Length;
			DFA132_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA132_transition[i] = DFA.UnpackEncodedString(DFA132_transitionS[i]);
			}
		}

		public DFA132( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 132;
			this.eot = DFA132_eot;
			this.eof = DFA132_eof;
			this.min = DFA132_min;
			this.max = DFA132_max;
			this.accept = DFA132_accept;
			this.special = DFA132_special;
			this.transition = DFA132_transition;
		}

		public override string Description { get { return "()* loopback of 229:90: ( ( LT )* memberExpressionSuffix )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition132(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA132_1 = input.LA(1);


				int index132_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred154_JavaScript_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 2;}


				input.Seek(index132_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 132, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA136 : DFA
	{
		private const string DFA136_eotS =
			"\x1A\xFFFF";
		private const string DFA136_eofS =
			"\x1\x2\x19\xFFFF";
		private const string DFA136_minS =
			"\x1\x4\x1\x0\x18\xFFFF";
		private const string DFA136_maxS =
			"\x1\x64\x1\x0\x18\xFFFF";
		private const string DFA136_acceptS =
			"\x2\xFFFF\x1\x2\x14\xFFFF\x1\x1\x2\xFFFF";
		private const string DFA136_specialS =
			"\x1\xFFFF\x1\x0\x18\xFFFF}>";
		private static readonly string[] DFA136_transitionS =
			{
				"\x1\x1\x1B\xFFFF\x1\x17\x2\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x5\xFFFF"+
				"\x1\x2\x4\xFFFF\x1\x2\x8\xFFFF\x1\x17\x1\x2\x1\x17\x22\x2\x3\xFFFF\x2"+
				"\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA136_eot = DFA.UnpackEncodedString(DFA136_eotS);
		private static readonly short[] DFA136_eof = DFA.UnpackEncodedString(DFA136_eofS);
		private static readonly char[] DFA136_min = DFA.UnpackEncodedStringToUnsignedChars(DFA136_minS);
		private static readonly char[] DFA136_max = DFA.UnpackEncodedStringToUnsignedChars(DFA136_maxS);
		private static readonly short[] DFA136_accept = DFA.UnpackEncodedString(DFA136_acceptS);
		private static readonly short[] DFA136_special = DFA.UnpackEncodedString(DFA136_specialS);
		private static readonly short[][] DFA136_transition;

		static DFA136()
		{
			int numStates = DFA136_transitionS.Length;
			DFA136_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA136_transition[i] = DFA.UnpackEncodedString(DFA136_transitionS[i]);
			}
		}

		public DFA136( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 136;
			this.eot = DFA136_eot;
			this.eof = DFA136_eof;
			this.min = DFA136_min;
			this.max = DFA136_max;
			this.accept = DFA136_accept;
			this.special = DFA136_special;
			this.transition = DFA136_transition;
		}

		public override string Description { get { return "()* loopback of 238:36: ( ( LT )* callExpressionSuffix )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition136(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA136_1 = input.LA(1);


				int index136_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred158_JavaScript_fragment)) ) {s = 23;}

				else if ( (true) ) {s = 2;}


				input.Seek(index136_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 136, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA142 : DFA
	{
		private const string DFA142_eotS =
			"\x4\xFFFF";
		private const string DFA142_eofS =
			"\x4\xFFFF";
		private const string DFA142_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA142_maxS =
			"\x2\x6A\x2\xFFFF";
		private const string DFA142_acceptS =
			"\x2\xFFFF\x1\x1\x1\x2";
		private const string DFA142_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA142_transitionS =
			{
				"\x1\x1\x3\x2\x17\xFFFF\x2\x2\x1\xFFFF\x1\x3\x1\x2\x16\xFFFF\x2\x2\x1F"+
				"\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"\x1\x1\x3\x2\x17\xFFFF\x2\x2\x1\xFFFF\x1\x3\x1\x2\x16\xFFFF\x2\x2"+
				"\x1F\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"",
				""
			};

		private static readonly short[] DFA142_eot = DFA.UnpackEncodedString(DFA142_eotS);
		private static readonly short[] DFA142_eof = DFA.UnpackEncodedString(DFA142_eofS);
		private static readonly char[] DFA142_min = DFA.UnpackEncodedStringToUnsignedChars(DFA142_minS);
		private static readonly char[] DFA142_max = DFA.UnpackEncodedStringToUnsignedChars(DFA142_maxS);
		private static readonly short[] DFA142_accept = DFA.UnpackEncodedString(DFA142_acceptS);
		private static readonly short[] DFA142_special = DFA.UnpackEncodedString(DFA142_specialS);
		private static readonly short[][] DFA142_transition;

		static DFA142()
		{
			int numStates = DFA142_transitionS.Length;
			DFA142_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA142_transition[i] = DFA.UnpackEncodedString(DFA142_transitionS[i]);
			}
		}

		public DFA142( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 142;
			this.eot = DFA142_eot;
			this.eof = DFA142_eof;
			this.min = DFA142_min;
			this.max = DFA142_max;
			this.accept = DFA142_accept;
			this.special = DFA142_special;
			this.transition = DFA142_transition;
		}

		public override string Description { get { return "248:8: ( ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA141 : DFA
	{
		private const string DFA141_eotS =
			"\x4\xFFFF";
		private const string DFA141_eofS =
			"\x4\xFFFF";
		private const string DFA141_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA141_maxS =
			"\x2\x22\x2\xFFFF";
		private const string DFA141_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA141_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA141_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x3\x1\x2",
				"\x1\x1\x1C\xFFFF\x1\x3\x1\x2",
				"",
				""
			};

		private static readonly short[] DFA141_eot = DFA.UnpackEncodedString(DFA141_eotS);
		private static readonly short[] DFA141_eof = DFA.UnpackEncodedString(DFA141_eofS);
		private static readonly char[] DFA141_min = DFA.UnpackEncodedStringToUnsignedChars(DFA141_minS);
		private static readonly char[] DFA141_max = DFA.UnpackEncodedStringToUnsignedChars(DFA141_maxS);
		private static readonly short[] DFA141_accept = DFA.UnpackEncodedString(DFA141_acceptS);
		private static readonly short[] DFA141_special = DFA.UnpackEncodedString(DFA141_specialS);
		private static readonly short[][] DFA141_transition;

		static DFA141()
		{
			int numStates = DFA141_transitionS.Length;
			DFA141_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA141_transition[i] = DFA.UnpackEncodedString(DFA141_transitionS[i]);
			}
		}

		public DFA141( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 141;
			this.eot = DFA141_eot;
			this.eof = DFA141_eof;
			this.min = DFA141_min;
			this.max = DFA141_max;
			this.accept = DFA141_accept;
			this.special = DFA141_special;
			this.transition = DFA141_transition;
		}

		public override string Description { get { return "()* loopback of 248:35: ( ( LT )* ',' ( LT )* assignmentExpression )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA151 : DFA
	{
		private const string DFA151_eotS =
			"\x5\xFFFF";
		private const string DFA151_eofS =
			"\x2\x3\x2\xFFFF\x1\x3";
		private const string DFA151_minS =
			"\x2\x4\x2\xFFFF\x1\x4";
		private const string DFA151_maxS =
			"\x1\x49\x1\x6A\x2\xFFFF\x1\x6A";
		private const string DFA151_acceptS =
			"\x2\xFFFF\x1\x1\x1\x2\x1\xFFFF";
		private const string DFA151_specialS =
			"\x5\xFFFF}>";
		private static readonly string[] DFA151_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x2\x3\x1\xFFFF\x1\x3\x1\xFFFF\x1\x3\xB\xFFFF\x1\x3"+
				"\x9\xFFFF\x1\x3\xC\xFFFF\x1\x2",
				"\x1\x4\x3\x3\x17\xFFFF\x8\x3\x1\xFFFF\x5\x3\x1\xFFFF\xA\x3\x2\xFFFF"+
				"\x3\x3\xC\xFFFF\x1\x2\x11\xFFFF\x2\x3\x3\xFFFF\xB\x3",
				"",
				"",
				"\x1\x4\x3\x3\x17\xFFFF\x8\x3\x1\xFFFF\x5\x3\x1\xFFFF\xA\x3\x2\xFFFF"+
				"\x3\x3\xC\xFFFF\x1\x2\x11\xFFFF\x2\x3\x3\xFFFF\xB\x3"
			};

		private static readonly short[] DFA151_eot = DFA.UnpackEncodedString(DFA151_eotS);
		private static readonly short[] DFA151_eof = DFA.UnpackEncodedString(DFA151_eofS);
		private static readonly char[] DFA151_min = DFA.UnpackEncodedStringToUnsignedChars(DFA151_minS);
		private static readonly char[] DFA151_max = DFA.UnpackEncodedStringToUnsignedChars(DFA151_maxS);
		private static readonly short[] DFA151_accept = DFA.UnpackEncodedString(DFA151_acceptS);
		private static readonly short[] DFA151_special = DFA.UnpackEncodedString(DFA151_specialS);
		private static readonly short[][] DFA151_transition;

		static DFA151()
		{
			int numStates = DFA151_transitionS.Length;
			DFA151_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA151_transition[i] = DFA.UnpackEncodedString(DFA151_transitionS[i]);
			}
		}

		public DFA151( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 151;
			this.eot = DFA151_eot;
			this.eof = DFA151_eof;
			this.min = DFA151_min;
			this.max = DFA151_max;
			this.accept = DFA151_accept;
			this.special = DFA151_special;
			this.transition = DFA151_transition;
		}

		public override string Description { get { return "264:24: ( ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA156 : DFA
	{
		private const string DFA156_eotS =
			"\x4\xFFFF";
		private const string DFA156_eofS =
			"\x1\x3\x3\xFFFF";
		private const string DFA156_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA156_maxS =
			"\x2\x49\x2\xFFFF";
		private const string DFA156_acceptS =
			"\x2\xFFFF\x1\x1\x1\x2";
		private const string DFA156_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA156_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x3\x4\xFFFF\x1\x3\x6\xFFFF\x1\x3\x4\xFFFF\x1\x3"+
				"\x16\xFFFF\x1\x2",
				"\x1\x1\x1C\xFFFF\x1\x3\x4\xFFFF\x1\x3\x6\xFFFF\x1\x3\x4\xFFFF\x1\x3"+
				"\x16\xFFFF\x1\x2",
				"",
				""
			};

		private static readonly short[] DFA156_eot = DFA.UnpackEncodedString(DFA156_eotS);
		private static readonly short[] DFA156_eof = DFA.UnpackEncodedString(DFA156_eofS);
		private static readonly char[] DFA156_min = DFA.UnpackEncodedStringToUnsignedChars(DFA156_minS);
		private static readonly char[] DFA156_max = DFA.UnpackEncodedStringToUnsignedChars(DFA156_maxS);
		private static readonly short[] DFA156_accept = DFA.UnpackEncodedString(DFA156_acceptS);
		private static readonly short[] DFA156_special = DFA.UnpackEncodedString(DFA156_specialS);
		private static readonly short[][] DFA156_transition;

		static DFA156()
		{
			int numStates = DFA156_transitionS.Length;
			DFA156_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA156_transition[i] = DFA.UnpackEncodedString(DFA156_transitionS[i]);
			}
		}

		public DFA156( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 156;
			this.eot = DFA156_eot;
			this.eof = DFA156_eof;
			this.min = DFA156_min;
			this.max = DFA156_max;
			this.accept = DFA156_accept;
			this.special = DFA156_special;
			this.transition = DFA156_transition;
		}

		public override string Description { get { return "268:28: ( ( LT )* '?' ( LT )* assignmentExpressionNoIn ( LT )* ':' ( LT )* assignmentExpressionNoIn )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA159 : DFA
	{
		private const string DFA159_eotS =
			"\x5\xFFFF";
		private const string DFA159_eofS =
			"\x2\x2\x2\xFFFF\x1\x2";
		private const string DFA159_minS =
			"\x2\x4\x2\xFFFF\x1\x4";
		private const string DFA159_maxS =
			"\x1\x4A\x1\x6A\x2\xFFFF\x1\x6A";
		private const string DFA159_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1\x1\xFFFF";
		private const string DFA159_specialS =
			"\x5\xFFFF}>";
		private static readonly string[] DFA159_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x2\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\xB\xFFFF\x1\x2"+
				"\x9\xFFFF\x1\x2\xC\xFFFF\x1\x2\x1\x3",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x5\x2\x1\xFFFF\xA\x2\x2\xFFFF"+
				"\x3\x2\xC\xFFFF\x1\x2\x1\x3\x10\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"",
				"",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x5\x2\x1\xFFFF\xA\x2\x2\xFFFF"+
				"\x3\x2\xC\xFFFF\x1\x2\x1\x3\x10\xFFFF\x2\x2\x3\xFFFF\xB\x2"
			};

		private static readonly short[] DFA159_eot = DFA.UnpackEncodedString(DFA159_eotS);
		private static readonly short[] DFA159_eof = DFA.UnpackEncodedString(DFA159_eofS);
		private static readonly char[] DFA159_min = DFA.UnpackEncodedStringToUnsignedChars(DFA159_minS);
		private static readonly char[] DFA159_max = DFA.UnpackEncodedStringToUnsignedChars(DFA159_maxS);
		private static readonly short[] DFA159_accept = DFA.UnpackEncodedString(DFA159_acceptS);
		private static readonly short[] DFA159_special = DFA.UnpackEncodedString(DFA159_specialS);
		private static readonly short[][] DFA159_transition;

		static DFA159()
		{
			int numStates = DFA159_transitionS.Length;
			DFA159_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA159_transition[i] = DFA.UnpackEncodedString(DFA159_transitionS[i]);
			}
		}

		public DFA159( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 159;
			this.eot = DFA159_eot;
			this.eof = DFA159_eof;
			this.min = DFA159_min;
			this.max = DFA159_max;
			this.accept = DFA159_accept;
			this.special = DFA159_special;
			this.transition = DFA159_transition;
		}

		public override string Description { get { return "()* loopback of 272:25: ( ( LT )* '||' ( LT )* logicalANDExpression )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA162 : DFA
	{
		private const string DFA162_eotS =
			"\x4\xFFFF";
		private const string DFA162_eofS =
			"\x1\x2\x3\xFFFF";
		private const string DFA162_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA162_maxS =
			"\x2\x4A\x2\xFFFF";
		private const string DFA162_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA162_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA162_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\x6\xFFFF\x1\x2\x4\xFFFF\x1\x2"+
				"\x16\xFFFF\x1\x2\x1\x3",
				"\x1\x1\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\x6\xFFFF\x1\x2\x4\xFFFF\x1\x2"+
				"\x16\xFFFF\x1\x2\x1\x3",
				"",
				""
			};

		private static readonly short[] DFA162_eot = DFA.UnpackEncodedString(DFA162_eotS);
		private static readonly short[] DFA162_eof = DFA.UnpackEncodedString(DFA162_eofS);
		private static readonly char[] DFA162_min = DFA.UnpackEncodedStringToUnsignedChars(DFA162_minS);
		private static readonly char[] DFA162_max = DFA.UnpackEncodedStringToUnsignedChars(DFA162_maxS);
		private static readonly short[] DFA162_accept = DFA.UnpackEncodedString(DFA162_acceptS);
		private static readonly short[] DFA162_special = DFA.UnpackEncodedString(DFA162_specialS);
		private static readonly short[][] DFA162_transition;

		static DFA162()
		{
			int numStates = DFA162_transitionS.Length;
			DFA162_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA162_transition[i] = DFA.UnpackEncodedString(DFA162_transitionS[i]);
			}
		}

		public DFA162( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 162;
			this.eot = DFA162_eot;
			this.eof = DFA162_eof;
			this.min = DFA162_min;
			this.max = DFA162_max;
			this.accept = DFA162_accept;
			this.special = DFA162_special;
			this.transition = DFA162_transition;
		}

		public override string Description { get { return "()* loopback of 276:29: ( ( LT )* '||' ( LT )* logicalANDExpressionNoIn )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA165 : DFA
	{
		private const string DFA165_eotS =
			"\x5\xFFFF";
		private const string DFA165_eofS =
			"\x2\x2\x2\xFFFF\x1\x2";
		private const string DFA165_minS =
			"\x2\x4\x2\xFFFF\x1\x4";
		private const string DFA165_maxS =
			"\x1\x4B\x1\x6A\x2\xFFFF\x1\x6A";
		private const string DFA165_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1\x1\xFFFF";
		private const string DFA165_specialS =
			"\x5\xFFFF}>";
		private static readonly string[] DFA165_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x2\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\xB\xFFFF\x1\x2"+
				"\x9\xFFFF\x1\x2\xC\xFFFF\x2\x2\x1\x3",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x5\x2\x1\xFFFF\xA\x2\x2\xFFFF"+
				"\x3\x2\xC\xFFFF\x2\x2\x1\x3\xF\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"",
				"",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x5\x2\x1\xFFFF\xA\x2\x2\xFFFF"+
				"\x3\x2\xC\xFFFF\x2\x2\x1\x3\xF\xFFFF\x2\x2\x3\xFFFF\xB\x2"
			};

		private static readonly short[] DFA165_eot = DFA.UnpackEncodedString(DFA165_eotS);
		private static readonly short[] DFA165_eof = DFA.UnpackEncodedString(DFA165_eofS);
		private static readonly char[] DFA165_min = DFA.UnpackEncodedStringToUnsignedChars(DFA165_minS);
		private static readonly char[] DFA165_max = DFA.UnpackEncodedStringToUnsignedChars(DFA165_maxS);
		private static readonly short[] DFA165_accept = DFA.UnpackEncodedString(DFA165_acceptS);
		private static readonly short[] DFA165_special = DFA.UnpackEncodedString(DFA165_specialS);
		private static readonly short[][] DFA165_transition;

		static DFA165()
		{
			int numStates = DFA165_transitionS.Length;
			DFA165_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA165_transition[i] = DFA.UnpackEncodedString(DFA165_transitionS[i]);
			}
		}

		public DFA165( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 165;
			this.eot = DFA165_eot;
			this.eof = DFA165_eof;
			this.min = DFA165_min;
			this.max = DFA165_max;
			this.accept = DFA165_accept;
			this.special = DFA165_special;
			this.transition = DFA165_transition;
		}

		public override string Description { get { return "()* loopback of 280:24: ( ( LT )* '&&' ( LT )* bitwiseORExpression )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA168 : DFA
	{
		private const string DFA168_eotS =
			"\x4\xFFFF";
		private const string DFA168_eofS =
			"\x1\x2\x3\xFFFF";
		private const string DFA168_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA168_maxS =
			"\x2\x4B\x2\xFFFF";
		private const string DFA168_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA168_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA168_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\x6\xFFFF\x1\x2\x4\xFFFF\x1\x2"+
				"\x16\xFFFF\x2\x2\x1\x3",
				"\x1\x1\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\x6\xFFFF\x1\x2\x4\xFFFF\x1\x2"+
				"\x16\xFFFF\x2\x2\x1\x3",
				"",
				""
			};

		private static readonly short[] DFA168_eot = DFA.UnpackEncodedString(DFA168_eotS);
		private static readonly short[] DFA168_eof = DFA.UnpackEncodedString(DFA168_eofS);
		private static readonly char[] DFA168_min = DFA.UnpackEncodedStringToUnsignedChars(DFA168_minS);
		private static readonly char[] DFA168_max = DFA.UnpackEncodedStringToUnsignedChars(DFA168_maxS);
		private static readonly short[] DFA168_accept = DFA.UnpackEncodedString(DFA168_acceptS);
		private static readonly short[] DFA168_special = DFA.UnpackEncodedString(DFA168_specialS);
		private static readonly short[][] DFA168_transition;

		static DFA168()
		{
			int numStates = DFA168_transitionS.Length;
			DFA168_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA168_transition[i] = DFA.UnpackEncodedString(DFA168_transitionS[i]);
			}
		}

		public DFA168( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 168;
			this.eot = DFA168_eot;
			this.eof = DFA168_eof;
			this.min = DFA168_min;
			this.max = DFA168_max;
			this.accept = DFA168_accept;
			this.special = DFA168_special;
			this.transition = DFA168_transition;
		}

		public override string Description { get { return "()* loopback of 284:28: ( ( LT )* '&&' ( LT )* bitwiseORExpressionNoIn )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA171 : DFA
	{
		private const string DFA171_eotS =
			"\x5\xFFFF";
		private const string DFA171_eofS =
			"\x2\x2\x2\xFFFF\x1\x2";
		private const string DFA171_minS =
			"\x2\x4\x2\xFFFF\x1\x4";
		private const string DFA171_maxS =
			"\x1\x4C\x1\x6A\x2\xFFFF\x1\x6A";
		private const string DFA171_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1\x1\xFFFF";
		private const string DFA171_specialS =
			"\x5\xFFFF}>";
		private static readonly string[] DFA171_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x2\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\xB\xFFFF\x1\x2"+
				"\x9\xFFFF\x1\x2\xC\xFFFF\x3\x2\x1\x3",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x5\x2\x1\xFFFF\xA\x2\x2\xFFFF"+
				"\x3\x2\xC\xFFFF\x3\x2\x1\x3\xE\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"",
				"",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x5\x2\x1\xFFFF\xA\x2\x2\xFFFF"+
				"\x3\x2\xC\xFFFF\x3\x2\x1\x3\xE\xFFFF\x2\x2\x3\xFFFF\xB\x2"
			};

		private static readonly short[] DFA171_eot = DFA.UnpackEncodedString(DFA171_eotS);
		private static readonly short[] DFA171_eof = DFA.UnpackEncodedString(DFA171_eofS);
		private static readonly char[] DFA171_min = DFA.UnpackEncodedStringToUnsignedChars(DFA171_minS);
		private static readonly char[] DFA171_max = DFA.UnpackEncodedStringToUnsignedChars(DFA171_maxS);
		private static readonly short[] DFA171_accept = DFA.UnpackEncodedString(DFA171_acceptS);
		private static readonly short[] DFA171_special = DFA.UnpackEncodedString(DFA171_specialS);
		private static readonly short[][] DFA171_transition;

		static DFA171()
		{
			int numStates = DFA171_transitionS.Length;
			DFA171_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA171_transition[i] = DFA.UnpackEncodedString(DFA171_transitionS[i]);
			}
		}

		public DFA171( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 171;
			this.eot = DFA171_eot;
			this.eof = DFA171_eof;
			this.min = DFA171_min;
			this.max = DFA171_max;
			this.accept = DFA171_accept;
			this.special = DFA171_special;
			this.transition = DFA171_transition;
		}

		public override string Description { get { return "()* loopback of 288:25: ( ( LT )* '|' ( LT )* bitwiseXORExpression )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA174 : DFA
	{
		private const string DFA174_eotS =
			"\x4\xFFFF";
		private const string DFA174_eofS =
			"\x1\x2\x3\xFFFF";
		private const string DFA174_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA174_maxS =
			"\x2\x4C\x2\xFFFF";
		private const string DFA174_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA174_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA174_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\x6\xFFFF\x1\x2\x4\xFFFF\x1\x2"+
				"\x16\xFFFF\x3\x2\x1\x3",
				"\x1\x1\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\x6\xFFFF\x1\x2\x4\xFFFF\x1\x2"+
				"\x16\xFFFF\x3\x2\x1\x3",
				"",
				""
			};

		private static readonly short[] DFA174_eot = DFA.UnpackEncodedString(DFA174_eotS);
		private static readonly short[] DFA174_eof = DFA.UnpackEncodedString(DFA174_eofS);
		private static readonly char[] DFA174_min = DFA.UnpackEncodedStringToUnsignedChars(DFA174_minS);
		private static readonly char[] DFA174_max = DFA.UnpackEncodedStringToUnsignedChars(DFA174_maxS);
		private static readonly short[] DFA174_accept = DFA.UnpackEncodedString(DFA174_acceptS);
		private static readonly short[] DFA174_special = DFA.UnpackEncodedString(DFA174_specialS);
		private static readonly short[][] DFA174_transition;

		static DFA174()
		{
			int numStates = DFA174_transitionS.Length;
			DFA174_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA174_transition[i] = DFA.UnpackEncodedString(DFA174_transitionS[i]);
			}
		}

		public DFA174( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 174;
			this.eot = DFA174_eot;
			this.eof = DFA174_eof;
			this.min = DFA174_min;
			this.max = DFA174_max;
			this.accept = DFA174_accept;
			this.special = DFA174_special;
			this.transition = DFA174_transition;
		}

		public override string Description { get { return "()* loopback of 292:29: ( ( LT )* '|' ( LT )* bitwiseXORExpressionNoIn )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA177 : DFA
	{
		private const string DFA177_eotS =
			"\x5\xFFFF";
		private const string DFA177_eofS =
			"\x2\x2\x2\xFFFF\x1\x2";
		private const string DFA177_minS =
			"\x2\x4\x2\xFFFF\x1\x4";
		private const string DFA177_maxS =
			"\x1\x4D\x1\x6A\x2\xFFFF\x1\x6A";
		private const string DFA177_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1\x1\xFFFF";
		private const string DFA177_specialS =
			"\x5\xFFFF}>";
		private static readonly string[] DFA177_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x2\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\xB\xFFFF\x1\x2"+
				"\x9\xFFFF\x1\x2\xC\xFFFF\x4\x2\x1\x3",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x5\x2\x1\xFFFF\xA\x2\x2\xFFFF"+
				"\x3\x2\xC\xFFFF\x4\x2\x1\x3\xD\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"",
				"",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x5\x2\x1\xFFFF\xA\x2\x2\xFFFF"+
				"\x3\x2\xC\xFFFF\x4\x2\x1\x3\xD\xFFFF\x2\x2\x3\xFFFF\xB\x2"
			};

		private static readonly short[] DFA177_eot = DFA.UnpackEncodedString(DFA177_eotS);
		private static readonly short[] DFA177_eof = DFA.UnpackEncodedString(DFA177_eofS);
		private static readonly char[] DFA177_min = DFA.UnpackEncodedStringToUnsignedChars(DFA177_minS);
		private static readonly char[] DFA177_max = DFA.UnpackEncodedStringToUnsignedChars(DFA177_maxS);
		private static readonly short[] DFA177_accept = DFA.UnpackEncodedString(DFA177_acceptS);
		private static readonly short[] DFA177_special = DFA.UnpackEncodedString(DFA177_specialS);
		private static readonly short[][] DFA177_transition;

		static DFA177()
		{
			int numStates = DFA177_transitionS.Length;
			DFA177_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA177_transition[i] = DFA.UnpackEncodedString(DFA177_transitionS[i]);
			}
		}

		public DFA177( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 177;
			this.eot = DFA177_eot;
			this.eof = DFA177_eof;
			this.min = DFA177_min;
			this.max = DFA177_max;
			this.accept = DFA177_accept;
			this.special = DFA177_special;
			this.transition = DFA177_transition;
		}

		public override string Description { get { return "()* loopback of 296:25: ( ( LT )* '^' ( LT )* bitwiseANDExpression )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA180 : DFA
	{
		private const string DFA180_eotS =
			"\x4\xFFFF";
		private const string DFA180_eofS =
			"\x1\x2\x3\xFFFF";
		private const string DFA180_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA180_maxS =
			"\x2\x4D\x2\xFFFF";
		private const string DFA180_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA180_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA180_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\x6\xFFFF\x1\x2\x4\xFFFF\x1\x2"+
				"\x16\xFFFF\x4\x2\x1\x3",
				"\x1\x1\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\x6\xFFFF\x1\x2\x4\xFFFF\x1\x2"+
				"\x16\xFFFF\x4\x2\x1\x3",
				"",
				""
			};

		private static readonly short[] DFA180_eot = DFA.UnpackEncodedString(DFA180_eotS);
		private static readonly short[] DFA180_eof = DFA.UnpackEncodedString(DFA180_eofS);
		private static readonly char[] DFA180_min = DFA.UnpackEncodedStringToUnsignedChars(DFA180_minS);
		private static readonly char[] DFA180_max = DFA.UnpackEncodedStringToUnsignedChars(DFA180_maxS);
		private static readonly short[] DFA180_accept = DFA.UnpackEncodedString(DFA180_acceptS);
		private static readonly short[] DFA180_special = DFA.UnpackEncodedString(DFA180_specialS);
		private static readonly short[][] DFA180_transition;

		static DFA180()
		{
			int numStates = DFA180_transitionS.Length;
			DFA180_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA180_transition[i] = DFA.UnpackEncodedString(DFA180_transitionS[i]);
			}
		}

		public DFA180( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 180;
			this.eot = DFA180_eot;
			this.eof = DFA180_eof;
			this.min = DFA180_min;
			this.max = DFA180_max;
			this.accept = DFA180_accept;
			this.special = DFA180_special;
			this.transition = DFA180_transition;
		}

		public override string Description { get { return "()* loopback of 300:29: ( ( LT )* '^' ( LT )* bitwiseANDExpressionNoIn )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA183 : DFA
	{
		private const string DFA183_eotS =
			"\x5\xFFFF";
		private const string DFA183_eofS =
			"\x2\x2\x2\xFFFF\x1\x2";
		private const string DFA183_minS =
			"\x2\x4\x2\xFFFF\x1\x4";
		private const string DFA183_maxS =
			"\x1\x4E\x1\x6A\x2\xFFFF\x1\x6A";
		private const string DFA183_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1\x1\xFFFF";
		private const string DFA183_specialS =
			"\x5\xFFFF}>";
		private static readonly string[] DFA183_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x2\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\xB\xFFFF\x1\x2"+
				"\x9\xFFFF\x1\x2\xC\xFFFF\x5\x2\x1\x3",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x5\x2\x1\xFFFF\xA\x2\x2\xFFFF"+
				"\x3\x2\xC\xFFFF\x5\x2\x1\x3\xC\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"",
				"",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x5\x2\x1\xFFFF\xA\x2\x2\xFFFF"+
				"\x3\x2\xC\xFFFF\x5\x2\x1\x3\xC\xFFFF\x2\x2\x3\xFFFF\xB\x2"
			};

		private static readonly short[] DFA183_eot = DFA.UnpackEncodedString(DFA183_eotS);
		private static readonly short[] DFA183_eof = DFA.UnpackEncodedString(DFA183_eofS);
		private static readonly char[] DFA183_min = DFA.UnpackEncodedStringToUnsignedChars(DFA183_minS);
		private static readonly char[] DFA183_max = DFA.UnpackEncodedStringToUnsignedChars(DFA183_maxS);
		private static readonly short[] DFA183_accept = DFA.UnpackEncodedString(DFA183_acceptS);
		private static readonly short[] DFA183_special = DFA.UnpackEncodedString(DFA183_specialS);
		private static readonly short[][] DFA183_transition;

		static DFA183()
		{
			int numStates = DFA183_transitionS.Length;
			DFA183_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA183_transition[i] = DFA.UnpackEncodedString(DFA183_transitionS[i]);
			}
		}

		public DFA183( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 183;
			this.eot = DFA183_eot;
			this.eof = DFA183_eof;
			this.min = DFA183_min;
			this.max = DFA183_max;
			this.accept = DFA183_accept;
			this.special = DFA183_special;
			this.transition = DFA183_transition;
		}

		public override string Description { get { return "()* loopback of 304:23: ( ( LT )* '&' ( LT )* equalityExpression )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA186 : DFA
	{
		private const string DFA186_eotS =
			"\x4\xFFFF";
		private const string DFA186_eofS =
			"\x1\x2\x3\xFFFF";
		private const string DFA186_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA186_maxS =
			"\x2\x4E\x2\xFFFF";
		private const string DFA186_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA186_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA186_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\x6\xFFFF\x1\x2\x4\xFFFF\x1\x2"+
				"\x16\xFFFF\x5\x2\x1\x3",
				"\x1\x1\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\x6\xFFFF\x1\x2\x4\xFFFF\x1\x2"+
				"\x16\xFFFF\x5\x2\x1\x3",
				"",
				""
			};

		private static readonly short[] DFA186_eot = DFA.UnpackEncodedString(DFA186_eotS);
		private static readonly short[] DFA186_eof = DFA.UnpackEncodedString(DFA186_eofS);
		private static readonly char[] DFA186_min = DFA.UnpackEncodedStringToUnsignedChars(DFA186_minS);
		private static readonly char[] DFA186_max = DFA.UnpackEncodedStringToUnsignedChars(DFA186_maxS);
		private static readonly short[] DFA186_accept = DFA.UnpackEncodedString(DFA186_acceptS);
		private static readonly short[] DFA186_special = DFA.UnpackEncodedString(DFA186_specialS);
		private static readonly short[][] DFA186_transition;

		static DFA186()
		{
			int numStates = DFA186_transitionS.Length;
			DFA186_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA186_transition[i] = DFA.UnpackEncodedString(DFA186_transitionS[i]);
			}
		}

		public DFA186( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 186;
			this.eot = DFA186_eot;
			this.eof = DFA186_eof;
			this.min = DFA186_min;
			this.max = DFA186_max;
			this.accept = DFA186_accept;
			this.special = DFA186_special;
			this.transition = DFA186_transition;
		}

		public override string Description { get { return "()* loopback of 308:27: ( ( LT )* '&' ( LT )* equalityExpressionNoIn )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA189 : DFA
	{
		private const string DFA189_eotS =
			"\x5\xFFFF";
		private const string DFA189_eofS =
			"\x2\x2\x2\xFFFF\x1\x2";
		private const string DFA189_minS =
			"\x2\x4\x2\xFFFF\x1\x4";
		private const string DFA189_maxS =
			"\x1\x52\x1\x6A\x2\xFFFF\x1\x6A";
		private const string DFA189_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1\x1\xFFFF";
		private const string DFA189_specialS =
			"\x5\xFFFF}>";
		private static readonly string[] DFA189_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x2\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\xB\xFFFF\x1\x2"+
				"\x9\xFFFF\x1\x2\xC\xFFFF\x6\x2\x4\x3",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x5\x2\x1\xFFFF\xA\x2\x2\xFFFF"+
				"\x3\x2\xC\xFFFF\x6\x2\x4\x3\x8\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"",
				"",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x5\x2\x1\xFFFF\xA\x2\x2\xFFFF"+
				"\x3\x2\xC\xFFFF\x6\x2\x4\x3\x8\xFFFF\x2\x2\x3\xFFFF\xB\x2"
			};

		private static readonly short[] DFA189_eot = DFA.UnpackEncodedString(DFA189_eotS);
		private static readonly short[] DFA189_eof = DFA.UnpackEncodedString(DFA189_eofS);
		private static readonly char[] DFA189_min = DFA.UnpackEncodedStringToUnsignedChars(DFA189_minS);
		private static readonly char[] DFA189_max = DFA.UnpackEncodedStringToUnsignedChars(DFA189_maxS);
		private static readonly short[] DFA189_accept = DFA.UnpackEncodedString(DFA189_acceptS);
		private static readonly short[] DFA189_special = DFA.UnpackEncodedString(DFA189_specialS);
		private static readonly short[][] DFA189_transition;

		static DFA189()
		{
			int numStates = DFA189_transitionS.Length;
			DFA189_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA189_transition[i] = DFA.UnpackEncodedString(DFA189_transitionS[i]);
			}
		}

		public DFA189( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 189;
			this.eot = DFA189_eot;
			this.eof = DFA189_eof;
			this.min = DFA189_min;
			this.max = DFA189_max;
			this.accept = DFA189_accept;
			this.special = DFA189_special;
			this.transition = DFA189_transition;
		}

		public override string Description { get { return "()* loopback of 312:25: ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpression )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA192 : DFA
	{
		private const string DFA192_eotS =
			"\x4\xFFFF";
		private const string DFA192_eofS =
			"\x1\x2\x3\xFFFF";
		private const string DFA192_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA192_maxS =
			"\x2\x52\x2\xFFFF";
		private const string DFA192_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA192_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA192_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\x6\xFFFF\x1\x2\x4\xFFFF\x1\x2"+
				"\x16\xFFFF\x6\x2\x4\x3",
				"\x1\x1\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\x6\xFFFF\x1\x2\x4\xFFFF\x1\x2"+
				"\x16\xFFFF\x6\x2\x4\x3",
				"",
				""
			};

		private static readonly short[] DFA192_eot = DFA.UnpackEncodedString(DFA192_eotS);
		private static readonly short[] DFA192_eof = DFA.UnpackEncodedString(DFA192_eofS);
		private static readonly char[] DFA192_min = DFA.UnpackEncodedStringToUnsignedChars(DFA192_minS);
		private static readonly char[] DFA192_max = DFA.UnpackEncodedStringToUnsignedChars(DFA192_maxS);
		private static readonly short[] DFA192_accept = DFA.UnpackEncodedString(DFA192_acceptS);
		private static readonly short[] DFA192_special = DFA.UnpackEncodedString(DFA192_specialS);
		private static readonly short[][] DFA192_transition;

		static DFA192()
		{
			int numStates = DFA192_transitionS.Length;
			DFA192_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA192_transition[i] = DFA.UnpackEncodedString(DFA192_transitionS[i]);
			}
		}

		public DFA192( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 192;
			this.eot = DFA192_eot;
			this.eof = DFA192_eof;
			this.min = DFA192_min;
			this.max = DFA192_max;
			this.accept = DFA192_accept;
			this.special = DFA192_special;
			this.transition = DFA192_transition;
		}

		public override string Description { get { return "()* loopback of 316:29: ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpressionNoIn )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA195 : DFA
	{
		private const string DFA195_eotS =
			"\x5\xFFFF";
		private const string DFA195_eofS =
			"\x2\x2\x2\xFFFF\x1\x2";
		private const string DFA195_minS =
			"\x2\x4\x2\xFFFF\x1\x4";
		private const string DFA195_maxS =
			"\x1\x57\x1\x6A\x2\xFFFF\x1\x6A";
		private const string DFA195_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1\x1\xFFFF";
		private const string DFA195_specialS =
			"\x5\xFFFF}>";
		private static readonly string[] DFA195_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x2\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x6\xFFFF\x1\x3"+
				"\x4\xFFFF\x1\x2\x9\xFFFF\x1\x2\xC\xFFFF\xA\x2\x5\x3",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x5\x2\x1\x3\xA\x2\x2\xFFFF\x3"+
				"\x2\xC\xFFFF\xA\x2\x5\x3\x3\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"",
				"",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x5\x2\x1\x3\xA\x2\x2\xFFFF\x3"+
				"\x2\xC\xFFFF\xA\x2\x5\x3\x3\xFFFF\x2\x2\x3\xFFFF\xB\x2"
			};

		private static readonly short[] DFA195_eot = DFA.UnpackEncodedString(DFA195_eotS);
		private static readonly short[] DFA195_eof = DFA.UnpackEncodedString(DFA195_eofS);
		private static readonly char[] DFA195_min = DFA.UnpackEncodedStringToUnsignedChars(DFA195_minS);
		private static readonly char[] DFA195_max = DFA.UnpackEncodedStringToUnsignedChars(DFA195_maxS);
		private static readonly short[] DFA195_accept = DFA.UnpackEncodedString(DFA195_acceptS);
		private static readonly short[] DFA195_special = DFA.UnpackEncodedString(DFA195_specialS);
		private static readonly short[][] DFA195_transition;

		static DFA195()
		{
			int numStates = DFA195_transitionS.Length;
			DFA195_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA195_transition[i] = DFA.UnpackEncodedString(DFA195_transitionS[i]);
			}
		}

		public DFA195( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 195;
			this.eot = DFA195_eot;
			this.eof = DFA195_eof;
			this.min = DFA195_min;
			this.max = DFA195_max;
			this.accept = DFA195_accept;
			this.special = DFA195_special;
			this.transition = DFA195_transition;
		}

		public override string Description { get { return "()* loopback of 320:20: ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' | 'in' ) ( LT )* shiftExpression )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA198 : DFA
	{
		private const string DFA198_eotS =
			"\x4\xFFFF";
		private const string DFA198_eofS =
			"\x1\x2\x3\xFFFF";
		private const string DFA198_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA198_maxS =
			"\x2\x57\x2\xFFFF";
		private const string DFA198_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA198_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA198_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\x6\xFFFF\x1\x2\x4\xFFFF\x1\x2"+
				"\x16\xFFFF\xA\x2\x5\x3",
				"\x1\x1\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\x6\xFFFF\x1\x2\x4\xFFFF\x1\x2"+
				"\x16\xFFFF\xA\x2\x5\x3",
				"",
				""
			};

		private static readonly short[] DFA198_eot = DFA.UnpackEncodedString(DFA198_eotS);
		private static readonly short[] DFA198_eof = DFA.UnpackEncodedString(DFA198_eofS);
		private static readonly char[] DFA198_min = DFA.UnpackEncodedStringToUnsignedChars(DFA198_minS);
		private static readonly char[] DFA198_max = DFA.UnpackEncodedStringToUnsignedChars(DFA198_maxS);
		private static readonly short[] DFA198_accept = DFA.UnpackEncodedString(DFA198_acceptS);
		private static readonly short[] DFA198_special = DFA.UnpackEncodedString(DFA198_specialS);
		private static readonly short[][] DFA198_transition;

		static DFA198()
		{
			int numStates = DFA198_transitionS.Length;
			DFA198_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA198_transition[i] = DFA.UnpackEncodedString(DFA198_transitionS[i]);
			}
		}

		public DFA198( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 198;
			this.eot = DFA198_eot;
			this.eof = DFA198_eof;
			this.min = DFA198_min;
			this.max = DFA198_max;
			this.accept = DFA198_accept;
			this.special = DFA198_special;
			this.transition = DFA198_transition;
		}

		public override string Description { get { return "()* loopback of 324:20: ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' ) ( LT )* shiftExpression )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA201 : DFA
	{
		private const string DFA201_eotS =
			"\x5\xFFFF";
		private const string DFA201_eofS =
			"\x2\x2\x2\xFFFF\x1\x2";
		private const string DFA201_minS =
			"\x2\x4\x2\xFFFF\x1\x4";
		private const string DFA201_maxS =
			"\x1\x5A\x1\x6A\x2\xFFFF\x1\x6A";
		private const string DFA201_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1\x1\xFFFF";
		private const string DFA201_specialS =
			"\x5\xFFFF}>";
		private static readonly string[] DFA201_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x2\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x6\xFFFF\x1\x2"+
				"\x4\xFFFF\x1\x2\x9\xFFFF\x1\x2\xC\xFFFF\xF\x2\x3\x3",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x10\x2\x2\xFFFF\x3\x2\xC\xFFFF"+
				"\xF\x2\x3\x3\x2\x2\x3\xFFFF\xB\x2",
				"",
				"",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x10\x2\x2\xFFFF\x3\x2\xC\xFFFF"+
				"\xF\x2\x3\x3\x2\x2\x3\xFFFF\xB\x2"
			};

		private static readonly short[] DFA201_eot = DFA.UnpackEncodedString(DFA201_eotS);
		private static readonly short[] DFA201_eof = DFA.UnpackEncodedString(DFA201_eofS);
		private static readonly char[] DFA201_min = DFA.UnpackEncodedStringToUnsignedChars(DFA201_minS);
		private static readonly char[] DFA201_max = DFA.UnpackEncodedStringToUnsignedChars(DFA201_maxS);
		private static readonly short[] DFA201_accept = DFA.UnpackEncodedString(DFA201_acceptS);
		private static readonly short[] DFA201_special = DFA.UnpackEncodedString(DFA201_specialS);
		private static readonly short[][] DFA201_transition;

		static DFA201()
		{
			int numStates = DFA201_transitionS.Length;
			DFA201_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA201_transition[i] = DFA.UnpackEncodedString(DFA201_transitionS[i]);
			}
		}

		public DFA201( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 201;
			this.eot = DFA201_eot;
			this.eof = DFA201_eof;
			this.min = DFA201_min;
			this.max = DFA201_max;
			this.accept = DFA201_accept;
			this.special = DFA201_special;
			this.transition = DFA201_transition;
		}

		public override string Description { get { return "()* loopback of 328:23: ( ( LT )* ( '<<' | '>>' | '>>>' ) ( LT )* additiveExpression )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA204 : DFA
	{
		private const string DFA204_eotS =
			"\x14\xFFFF";
		private const string DFA204_eofS =
			"\x1\x2\x13\xFFFF";
		private const string DFA204_minS =
			"\x1\x4\x1\x0\x12\xFFFF";
		private const string DFA204_maxS =
			"\x1\x5C\x1\x0\x12\xFFFF";
		private const string DFA204_acceptS =
			"\x2\xFFFF\x1\x2\x10\xFFFF\x1\x1";
		private const string DFA204_specialS =
			"\x1\xFFFF\x1\x0\x12\xFFFF}>";
		private static readonly string[] DFA204_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x2\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x6\xFFFF\x1\x2"+
				"\x4\xFFFF\x1\x2\x9\xFFFF\x1\x2\xC\xFFFF\x12\x2\x2\x13",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA204_eot = DFA.UnpackEncodedString(DFA204_eotS);
		private static readonly short[] DFA204_eof = DFA.UnpackEncodedString(DFA204_eofS);
		private static readonly char[] DFA204_min = DFA.UnpackEncodedStringToUnsignedChars(DFA204_minS);
		private static readonly char[] DFA204_max = DFA.UnpackEncodedStringToUnsignedChars(DFA204_maxS);
		private static readonly short[] DFA204_accept = DFA.UnpackEncodedString(DFA204_acceptS);
		private static readonly short[] DFA204_special = DFA.UnpackEncodedString(DFA204_specialS);
		private static readonly short[][] DFA204_transition;

		static DFA204()
		{
			int numStates = DFA204_transitionS.Length;
			DFA204_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA204_transition[i] = DFA.UnpackEncodedString(DFA204_transitionS[i]);
			}
		}

		public DFA204( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 204;
			this.eot = DFA204_eot;
			this.eof = DFA204_eof;
			this.min = DFA204_min;
			this.max = DFA204_max;
			this.accept = DFA204_accept;
			this.special = DFA204_special;
			this.transition = DFA204_transition;
		}

		public override string Description { get { return "()* loopback of 332:29: ( ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition204(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA204_1 = input.LA(1);


				int index204_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred256_JavaScript_fragment)) ) {s = 19;}

				else if ( (true) ) {s = 2;}


				input.Seek(index204_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 204, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA207 : DFA
	{
		private const string DFA207_eotS =
			"\x5\xFFFF";
		private const string DFA207_eofS =
			"\x2\x2\x2\xFFFF\x1\x2";
		private const string DFA207_minS =
			"\x2\x4\x2\xFFFF\x1\x4";
		private const string DFA207_maxS =
			"\x1\x5F\x1\x6A\x2\xFFFF\x1\x6A";
		private const string DFA207_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1\x1\xFFFF";
		private const string DFA207_specialS =
			"\x5\xFFFF}>";
		private static readonly string[] DFA207_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x2\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x6\xFFFF\x1\x2"+
				"\x4\xFFFF\x1\x2\x9\xFFFF\x1\x2\xC\xFFFF\x14\x2\x3\x3",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x10\x2\x2\xFFFF\x3\x2\xC\xFFFF"+
				"\x14\x2\x3\x3\xB\x2",
				"",
				"",
				"\x1\x4\x3\x2\x17\xFFFF\x8\x2\x1\xFFFF\x10\x2\x2\xFFFF\x3\x2\xC\xFFFF"+
				"\x14\x2\x3\x3\xB\x2"
			};

		private static readonly short[] DFA207_eot = DFA.UnpackEncodedString(DFA207_eotS);
		private static readonly short[] DFA207_eof = DFA.UnpackEncodedString(DFA207_eofS);
		private static readonly char[] DFA207_min = DFA.UnpackEncodedStringToUnsignedChars(DFA207_minS);
		private static readonly char[] DFA207_max = DFA.UnpackEncodedStringToUnsignedChars(DFA207_maxS);
		private static readonly short[] DFA207_accept = DFA.UnpackEncodedString(DFA207_acceptS);
		private static readonly short[] DFA207_special = DFA.UnpackEncodedString(DFA207_specialS);
		private static readonly short[][] DFA207_transition;

		static DFA207()
		{
			int numStates = DFA207_transitionS.Length;
			DFA207_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA207_transition[i] = DFA.UnpackEncodedString(DFA207_transitionS[i]);
			}
		}

		public DFA207( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 207;
			this.eot = DFA207_eot;
			this.eof = DFA207_eof;
			this.min = DFA207_min;
			this.max = DFA207_max;
			this.accept = DFA207_accept;
			this.special = DFA207_special;
			this.transition = DFA207_transition;
		}

		public override string Description { get { return "()* loopback of 336:20: ( ( LT )* ( '*' | '/' | '%' ) ( LT )* unaryExpression )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA218 : DFA
	{
		private const string DFA218_eotS =
			"\x4\xFFFF";
		private const string DFA218_eofS =
			"\x4\xFFFF";
		private const string DFA218_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA218_maxS =
			"\x2\x3C\x2\xFFFF";
		private const string DFA218_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA218_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA218_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x3\x1A\xFFFF\x1\x2",
				"\x1\x1\x1C\xFFFF\x1\x3\x1A\xFFFF\x1\x2",
				"",
				""
			};

		private static readonly short[] DFA218_eot = DFA.UnpackEncodedString(DFA218_eotS);
		private static readonly short[] DFA218_eof = DFA.UnpackEncodedString(DFA218_eofS);
		private static readonly char[] DFA218_min = DFA.UnpackEncodedStringToUnsignedChars(DFA218_minS);
		private static readonly char[] DFA218_max = DFA.UnpackEncodedStringToUnsignedChars(DFA218_maxS);
		private static readonly short[] DFA218_accept = DFA.UnpackEncodedString(DFA218_acceptS);
		private static readonly short[] DFA218_special = DFA.UnpackEncodedString(DFA218_specialS);
		private static readonly short[][] DFA218_transition;

		static DFA218()
		{
			int numStates = DFA218_transitionS.Length;
			DFA218_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA218_transition[i] = DFA.UnpackEncodedString(DFA218_transitionS[i]);
			}
		}

		public DFA218( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 218;
			this.eot = DFA218_eot;
			this.eof = DFA218_eof;
			this.min = DFA218_min;
			this.max = DFA218_max;
			this.accept = DFA218_accept;
			this.special = DFA218_special;
			this.transition = DFA218_transition;
		}

		public override string Description { get { return "()* loopback of 359:35: ( ( LT )* ',' ( ( LT )* assignmentExpression )? )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA217 : DFA
	{
		private const string DFA217_eotS =
			"\x4\xFFFF";
		private const string DFA217_eofS =
			"\x4\xFFFF";
		private const string DFA217_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA217_maxS =
			"\x2\x6A\x2\xFFFF";
		private const string DFA217_acceptS =
			"\x2\xFFFF\x1\x1\x1\x2";
		private const string DFA217_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA217_transitionS =
			{
				"\x1\x1\x3\x2\x17\xFFFF\x2\x2\x1\x3\x1\xFFFF\x1\x2\x16\xFFFF\x2\x2\x1"+
				"\x3\x1E\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"\x1\x1\x3\x2\x17\xFFFF\x2\x2\x1\x3\x1\xFFFF\x1\x2\x16\xFFFF\x2\x2"+
				"\x1\x3\x1E\xFFFF\x2\x2\x3\xFFFF\xB\x2",
				"",
				""
			};

		private static readonly short[] DFA217_eot = DFA.UnpackEncodedString(DFA217_eotS);
		private static readonly short[] DFA217_eof = DFA.UnpackEncodedString(DFA217_eofS);
		private static readonly char[] DFA217_min = DFA.UnpackEncodedStringToUnsignedChars(DFA217_minS);
		private static readonly char[] DFA217_max = DFA.UnpackEncodedStringToUnsignedChars(DFA217_maxS);
		private static readonly short[] DFA217_accept = DFA.UnpackEncodedString(DFA217_acceptS);
		private static readonly short[] DFA217_special = DFA.UnpackEncodedString(DFA217_specialS);
		private static readonly short[][] DFA217_transition;

		static DFA217()
		{
			int numStates = DFA217_transitionS.Length;
			DFA217_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA217_transition[i] = DFA.UnpackEncodedString(DFA217_transitionS[i]);
			}
		}

		public DFA217( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 217;
			this.eot = DFA217_eot;
			this.eof = DFA217_eof;
			this.min = DFA217_min;
			this.max = DFA217_max;
			this.accept = DFA217_accept;
			this.special = DFA217_special;
			this.transition = DFA217_transition;
		}

		public override string Description { get { return "359:45: ( ( LT )* assignmentExpression )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA223 : DFA
	{
		private const string DFA223_eotS =
			"\x4\xFFFF";
		private const string DFA223_eofS =
			"\x4\xFFFF";
		private const string DFA223_minS =
			"\x2\x4\x2\xFFFF";
		private const string DFA223_maxS =
			"\x2\x24\x2\xFFFF";
		private const string DFA223_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA223_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA223_transitionS =
			{
				"\x1\x1\x1C\xFFFF\x1\x3\x2\xFFFF\x1\x2",
				"\x1\x1\x1C\xFFFF\x1\x3\x2\xFFFF\x1\x2",
				"",
				""
			};

		private static readonly short[] DFA223_eot = DFA.UnpackEncodedString(DFA223_eotS);
		private static readonly short[] DFA223_eof = DFA.UnpackEncodedString(DFA223_eofS);
		private static readonly char[] DFA223_min = DFA.UnpackEncodedStringToUnsignedChars(DFA223_minS);
		private static readonly char[] DFA223_max = DFA.UnpackEncodedStringToUnsignedChars(DFA223_maxS);
		private static readonly short[] DFA223_accept = DFA.UnpackEncodedString(DFA223_acceptS);
		private static readonly short[] DFA223_special = DFA.UnpackEncodedString(DFA223_specialS);
		private static readonly short[][] DFA223_transition;

		static DFA223()
		{
			int numStates = DFA223_transitionS.Length;
			DFA223_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA223_transition[i] = DFA.UnpackEncodedString(DFA223_transitionS[i]);
			}
		}

		public DFA223( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 223;
			this.eot = DFA223_eot;
			this.eof = DFA223_eof;
			this.min = DFA223_min;
			this.max = DFA223_max;
			this.accept = DFA223_accept;
			this.special = DFA223_special;
			this.transition = DFA223_transition;
		}

		public override string Description { get { return "()* loopback of 364:34: ( ( LT )* ',' ( LT )* propertyNameAndValue )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _LT_in_program49 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _sourceElements_in_program53 = new BitSet(new ulong[]{0x10UL});
		public static readonly BitSet _LT_in_program55 = new BitSet(new ulong[]{0x10UL});
		public static readonly BitSet _EOF_in_program59 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _sourceElement_in_sourceElements72 = new BitSet(new ulong[]{0xCCBDD69800000F2UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_sourceElements75 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _sourceElement_in_sourceElements79 = new BitSet(new ulong[]{0xCCBDD69800000F2UL,0x7FF18000000UL});
		public static readonly BitSet _functionDeclaration_in_sourceElement93 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_sourceElement98 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _31_in_functionDeclaration111 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _LT_in_functionDeclaration113 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _Identifier_in_functionDeclaration117 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _LT_in_functionDeclaration119 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _formalParameterList_in_functionDeclaration123 = new BitSet(new ulong[]{0x800000010UL});
		public static readonly BitSet _LT_in_functionDeclaration125 = new BitSet(new ulong[]{0x800000010UL});
		public static readonly BitSet _functionBody_in_functionDeclaration129 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _31_in_functionExpression141 = new BitSet(new ulong[]{0x100000030UL});
		public static readonly BitSet _LT_in_functionExpression143 = new BitSet(new ulong[]{0x100000030UL});
		public static readonly BitSet _Identifier_in_functionExpression147 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _LT_in_functionExpression150 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _formalParameterList_in_functionExpression154 = new BitSet(new ulong[]{0x800000010UL});
		public static readonly BitSet _LT_in_functionExpression156 = new BitSet(new ulong[]{0x800000010UL});
		public static readonly BitSet _functionBody_in_functionExpression160 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _32_in_formalParameterList172 = new BitSet(new ulong[]{0x400000030UL});
		public static readonly BitSet _LT_in_formalParameterList175 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _Identifier_in_formalParameterList179 = new BitSet(new ulong[]{0x600000010UL});
		public static readonly BitSet _LT_in_formalParameterList182 = new BitSet(new ulong[]{0x200000010UL});
		public static readonly BitSet _33_in_formalParameterList186 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _LT_in_formalParameterList188 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _Identifier_in_formalParameterList192 = new BitSet(new ulong[]{0x600000010UL});
		public static readonly BitSet _LT_in_formalParameterList198 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _34_in_formalParameterList202 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _35_in_functionBody213 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_functionBody215 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _sourceElements_in_functionBody219 = new BitSet(new ulong[]{0x1000000010UL});
		public static readonly BitSet _LT_in_functionBody221 = new BitSet(new ulong[]{0x1000000010UL});
		public static readonly BitSet _36_in_functionBody225 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statementBlock_in_statement237 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _variableStatement_in_statement242 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _emptyStatement_in_statement247 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expressionStatement_in_statement252 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifStatement_in_statement257 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _iterationStatement_in_statement262 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _continueStatement_in_statement267 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _breakStatement_in_statement272 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _returnStatement_in_statement277 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _withStatement_in_statement282 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _labelledStatement_in_statement287 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _switchStatement_in_statement292 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _throwStatement_in_statement297 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _tryStatement_in_statement302 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _35_in_statementBlock314 = new BitSet(new ulong[]{0xCCBDD79800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_statementBlock316 = new BitSet(new ulong[]{0xCCBDD79800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _statementList_in_statementBlock320 = new BitSet(new ulong[]{0x1000000010UL});
		public static readonly BitSet _LT_in_statementBlock323 = new BitSet(new ulong[]{0x1000000010UL});
		public static readonly BitSet _36_in_statementBlock327 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementList339 = new BitSet(new ulong[]{0xCCBDD69800000F2UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_statementList342 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _statement_in_statementList346 = new BitSet(new ulong[]{0xCCBDD69800000F2UL,0x7FF18000000UL});
		public static readonly BitSet _37_in_variableStatement360 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _LT_in_variableStatement362 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _variableDeclarationList_in_variableStatement366 = new BitSet(new ulong[]{0x4000000010UL});
		public static readonly BitSet _set_in_variableStatement368 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _variableDeclaration_in_variableDeclarationList387 = new BitSet(new ulong[]{0x200000012UL});
		public static readonly BitSet _LT_in_variableDeclarationList390 = new BitSet(new ulong[]{0x200000010UL});
		public static readonly BitSet _33_in_variableDeclarationList394 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _LT_in_variableDeclarationList396 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _variableDeclaration_in_variableDeclarationList400 = new BitSet(new ulong[]{0x200000012UL});
		public static readonly BitSet _variableDeclarationNoIn_in_variableDeclarationListNoIn414 = new BitSet(new ulong[]{0x200000012UL});
		public static readonly BitSet _LT_in_variableDeclarationListNoIn417 = new BitSet(new ulong[]{0x200000010UL});
		public static readonly BitSet _33_in_variableDeclarationListNoIn421 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _LT_in_variableDeclarationListNoIn423 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _variableDeclarationNoIn_in_variableDeclarationListNoIn427 = new BitSet(new ulong[]{0x200000012UL});
		public static readonly BitSet _Identifier_in_variableDeclaration441 = new BitSet(new ulong[]{0x8000000012UL});
		public static readonly BitSet _LT_in_variableDeclaration443 = new BitSet(new ulong[]{0x8000000012UL});
		public static readonly BitSet _initialiser_in_variableDeclaration447 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Identifier_in_variableDeclarationNoIn460 = new BitSet(new ulong[]{0x8000000012UL});
		public static readonly BitSet _LT_in_variableDeclarationNoIn462 = new BitSet(new ulong[]{0x8000000012UL});
		public static readonly BitSet _initialiserNoIn_in_variableDeclarationNoIn466 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _39_in_initialiser479 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_initialiser481 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _assignmentExpression_in_initialiser485 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _39_in_initialiserNoIn497 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_initialiserNoIn499 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _assignmentExpressionNoIn_in_initialiserNoIn503 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _38_in_emptyStatement515 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressionStatement527 = new BitSet(new ulong[]{0x4000000010UL});
		public static readonly BitSet _set_in_expressionStatement529 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _40_in_ifStatement548 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _LT_in_ifStatement550 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _32_in_ifStatement554 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_ifStatement556 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _expression_in_ifStatement560 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _LT_in_ifStatement562 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _34_in_ifStatement566 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_ifStatement568 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _statement_in_ifStatement572 = new BitSet(new ulong[]{0x20000000012UL});
		public static readonly BitSet _LT_in_ifStatement575 = new BitSet(new ulong[]{0x20000000010UL});
		public static readonly BitSet _41_in_ifStatement579 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_ifStatement581 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _statement_in_ifStatement585 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _doWhileStatement_in_iterationStatement599 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whileStatement_in_iterationStatement604 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forStatement_in_iterationStatement609 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forInStatement_in_iterationStatement614 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _42_in_doWhileStatement626 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_doWhileStatement628 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _statement_in_doWhileStatement632 = new BitSet(new ulong[]{0x80000000010UL});
		public static readonly BitSet _LT_in_doWhileStatement634 = new BitSet(new ulong[]{0x80000000010UL});
		public static readonly BitSet _43_in_doWhileStatement638 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _LT_in_doWhileStatement640 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _32_in_doWhileStatement644 = new BitSet(new ulong[]{0xC000009800000E0UL,0x7FF18000000UL});
		public static readonly BitSet _expression_in_doWhileStatement646 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _34_in_doWhileStatement648 = new BitSet(new ulong[]{0x4000000010UL});
		public static readonly BitSet _set_in_doWhileStatement650 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _43_in_whileStatement669 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _LT_in_whileStatement671 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _32_in_whileStatement675 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_whileStatement677 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _expression_in_whileStatement681 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _LT_in_whileStatement683 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _34_in_whileStatement687 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_whileStatement689 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _statement_in_whileStatement693 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _44_in_forStatement705 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _LT_in_forStatement707 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _32_in_forStatement711 = new BitSet(new ulong[]{0xC000069800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_forStatement714 = new BitSet(new ulong[]{0xC000029800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _forStatementInitialiserPart_in_forStatement718 = new BitSet(new ulong[]{0x4000000010UL});
		public static readonly BitSet _LT_in_forStatement722 = new BitSet(new ulong[]{0x4000000010UL});
		public static readonly BitSet _38_in_forStatement726 = new BitSet(new ulong[]{0xC000049800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_forStatement729 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _expression_in_forStatement733 = new BitSet(new ulong[]{0x4000000010UL});
		public static readonly BitSet _LT_in_forStatement737 = new BitSet(new ulong[]{0x4000000010UL});
		public static readonly BitSet _38_in_forStatement741 = new BitSet(new ulong[]{0xC00000D800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_forStatement744 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _expression_in_forStatement748 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _LT_in_forStatement752 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _34_in_forStatement756 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_forStatement758 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _statement_in_forStatement762 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expressionNoIn_in_forStatementInitialiserPart774 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _37_in_forStatementInitialiserPart779 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _LT_in_forStatementInitialiserPart781 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _variableDeclarationListNoIn_in_forStatementInitialiserPart785 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _44_in_forInStatement797 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _LT_in_forInStatement799 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _32_in_forInStatement803 = new BitSet(new ulong[]{0xC000029800000F0UL,0x78000000000UL});
		public static readonly BitSet _LT_in_forInStatement805 = new BitSet(new ulong[]{0xC000029800000F0UL,0x78000000000UL});
		public static readonly BitSet _forInStatementInitialiserPart_in_forInStatement809 = new BitSet(new ulong[]{0x200000000010UL});
		public static readonly BitSet _LT_in_forInStatement811 = new BitSet(new ulong[]{0x200000000010UL});
		public static readonly BitSet _45_in_forInStatement815 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_forInStatement817 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _expression_in_forInStatement821 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _LT_in_forInStatement823 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _34_in_forInStatement827 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_forInStatement829 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _statement_in_forInStatement833 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _leftHandSideExpression_in_forInStatementInitialiserPart845 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _37_in_forInStatementInitialiserPart850 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _LT_in_forInStatementInitialiserPart852 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _variableDeclarationNoIn_in_forInStatementInitialiserPart856 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _46_in_continueStatement867 = new BitSet(new ulong[]{0x4000000030UL});
		public static readonly BitSet _Identifier_in_continueStatement869 = new BitSet(new ulong[]{0x4000000010UL});
		public static readonly BitSet _set_in_continueStatement872 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _47_in_breakStatement890 = new BitSet(new ulong[]{0x4000000030UL});
		public static readonly BitSet _Identifier_in_breakStatement892 = new BitSet(new ulong[]{0x4000000010UL});
		public static readonly BitSet _set_in_breakStatement895 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _48_in_returnStatement913 = new BitSet(new ulong[]{0xC000049800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _expression_in_returnStatement915 = new BitSet(new ulong[]{0x4000000010UL});
		public static readonly BitSet _set_in_returnStatement918 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _49_in_withStatement937 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _LT_in_withStatement939 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _32_in_withStatement943 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_withStatement945 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _expression_in_withStatement949 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _LT_in_withStatement951 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _34_in_withStatement955 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_withStatement957 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _statement_in_withStatement961 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Identifier_in_labelledStatement972 = new BitSet(new ulong[]{0x4000000000010UL});
		public static readonly BitSet _LT_in_labelledStatement974 = new BitSet(new ulong[]{0x4000000000010UL});
		public static readonly BitSet _50_in_labelledStatement978 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_labelledStatement980 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _statement_in_labelledStatement984 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _51_in_switchStatement996 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _LT_in_switchStatement998 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _32_in_switchStatement1002 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_switchStatement1004 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _expression_in_switchStatement1008 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _LT_in_switchStatement1010 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _34_in_switchStatement1014 = new BitSet(new ulong[]{0x800000010UL});
		public static readonly BitSet _LT_in_switchStatement1016 = new BitSet(new ulong[]{0x800000010UL});
		public static readonly BitSet _caseBlock_in_switchStatement1020 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _35_in_caseBlock1032 = new BitSet(new ulong[]{0x30001000000010UL});
		public static readonly BitSet _LT_in_caseBlock1035 = new BitSet(new ulong[]{0x10000000000010UL});
		public static readonly BitSet _caseClause_in_caseBlock1039 = new BitSet(new ulong[]{0x30001000000010UL});
		public static readonly BitSet _LT_in_caseBlock1044 = new BitSet(new ulong[]{0x20000000000010UL});
		public static readonly BitSet _defaultClause_in_caseBlock1048 = new BitSet(new ulong[]{0x10001000000010UL});
		public static readonly BitSet _LT_in_caseBlock1051 = new BitSet(new ulong[]{0x10000000000010UL});
		public static readonly BitSet _caseClause_in_caseBlock1055 = new BitSet(new ulong[]{0x10001000000010UL});
		public static readonly BitSet _LT_in_caseBlock1061 = new BitSet(new ulong[]{0x1000000010UL});
		public static readonly BitSet _36_in_caseBlock1065 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _52_in_caseClause1076 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_caseClause1078 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _expression_in_caseClause1082 = new BitSet(new ulong[]{0x4000000000010UL});
		public static readonly BitSet _LT_in_caseClause1084 = new BitSet(new ulong[]{0x4000000000010UL});
		public static readonly BitSet _50_in_caseClause1088 = new BitSet(new ulong[]{0xCCBDD69800000F2UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_caseClause1090 = new BitSet(new ulong[]{0xCCBDD69800000F2UL,0x7FF18000000UL});
		public static readonly BitSet _statementList_in_caseClause1094 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _53_in_defaultClause1107 = new BitSet(new ulong[]{0x4000000000010UL});
		public static readonly BitSet _LT_in_defaultClause1109 = new BitSet(new ulong[]{0x4000000000010UL});
		public static readonly BitSet _50_in_defaultClause1113 = new BitSet(new ulong[]{0xCCBDD69800000F2UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_defaultClause1115 = new BitSet(new ulong[]{0xCCBDD69800000F2UL,0x7FF18000000UL});
		public static readonly BitSet _statementList_in_defaultClause1119 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _54_in_throwStatement1132 = new BitSet(new ulong[]{0xC000009800000E0UL,0x7FF18000000UL});
		public static readonly BitSet _expression_in_throwStatement1134 = new BitSet(new ulong[]{0x4000000010UL});
		public static readonly BitSet _set_in_throwStatement1136 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _55_in_tryStatement1154 = new BitSet(new ulong[]{0x800000010UL});
		public static readonly BitSet _LT_in_tryStatement1156 = new BitSet(new ulong[]{0x800000010UL});
		public static readonly BitSet _statementBlock_in_tryStatement1160 = new BitSet(new ulong[]{0x300000000000010UL});
		public static readonly BitSet _LT_in_tryStatement1162 = new BitSet(new ulong[]{0x300000000000010UL});
		public static readonly BitSet _finallyClause_in_tryStatement1167 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _catchClause_in_tryStatement1171 = new BitSet(new ulong[]{0x200000000000012UL});
		public static readonly BitSet _LT_in_tryStatement1174 = new BitSet(new ulong[]{0x200000000000010UL});
		public static readonly BitSet _finallyClause_in_tryStatement1178 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _56_in_catchClause1199 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _LT_in_catchClause1201 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _32_in_catchClause1205 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _LT_in_catchClause1207 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _Identifier_in_catchClause1211 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _LT_in_catchClause1213 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _34_in_catchClause1217 = new BitSet(new ulong[]{0x800000010UL});
		public static readonly BitSet _LT_in_catchClause1219 = new BitSet(new ulong[]{0x800000010UL});
		public static readonly BitSet _statementBlock_in_catchClause1223 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _57_in_finallyClause1235 = new BitSet(new ulong[]{0x800000010UL});
		public static readonly BitSet _LT_in_finallyClause1237 = new BitSet(new ulong[]{0x800000010UL});
		public static readonly BitSet _statementBlock_in_finallyClause1241 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignmentExpression_in_expression1253 = new BitSet(new ulong[]{0x200000012UL});
		public static readonly BitSet _LT_in_expression1256 = new BitSet(new ulong[]{0x200000010UL});
		public static readonly BitSet _33_in_expression1260 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_expression1262 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _assignmentExpression_in_expression1266 = new BitSet(new ulong[]{0x200000012UL});
		public static readonly BitSet _assignmentExpressionNoIn_in_expressionNoIn1280 = new BitSet(new ulong[]{0x200000012UL});
		public static readonly BitSet _LT_in_expressionNoIn1283 = new BitSet(new ulong[]{0x200000010UL});
		public static readonly BitSet _33_in_expressionNoIn1287 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_expressionNoIn1289 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _assignmentExpressionNoIn_in_expressionNoIn1293 = new BitSet(new ulong[]{0x200000012UL});
		public static readonly BitSet _conditionalExpression_in_assignmentExpression1307 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _leftHandSideExpression_in_assignmentExpression1312 = new BitSet(new ulong[]{0xC000008000000010UL,0x1FFUL});
		public static readonly BitSet _LT_in_assignmentExpression1314 = new BitSet(new ulong[]{0xC000008000000010UL,0x1FFUL});
		public static readonly BitSet _assignmentOperator_in_assignmentExpression1318 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_assignmentExpression1320 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _assignmentExpression_in_assignmentExpression1324 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _conditionalExpressionNoIn_in_assignmentExpressionNoIn1336 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _leftHandSideExpression_in_assignmentExpressionNoIn1341 = new BitSet(new ulong[]{0xC000008000000010UL,0x1FFUL});
		public static readonly BitSet _LT_in_assignmentExpressionNoIn1343 = new BitSet(new ulong[]{0xC000008000000010UL,0x1FFUL});
		public static readonly BitSet _assignmentOperator_in_assignmentExpressionNoIn1347 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_assignmentExpressionNoIn1349 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _assignmentExpressionNoIn_in_assignmentExpressionNoIn1353 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _callExpression_in_leftHandSideExpression1365 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newExpression_in_leftHandSideExpression1370 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _memberExpression_in_newExpression1382 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _58_in_newExpression1387 = new BitSet(new ulong[]{0xC000009800000F0UL,0x78000000000UL});
		public static readonly BitSet _LT_in_newExpression1389 = new BitSet(new ulong[]{0xC000009800000F0UL,0x78000000000UL});
		public static readonly BitSet _newExpression_in_newExpression1393 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _primaryExpression_in_memberExpression1406 = new BitSet(new ulong[]{0x2800000000000012UL});
		public static readonly BitSet _functionExpression_in_memberExpression1410 = new BitSet(new ulong[]{0x2800000000000012UL});
		public static readonly BitSet _58_in_memberExpression1414 = new BitSet(new ulong[]{0xC000009800000F0UL,0x78000000000UL});
		public static readonly BitSet _LT_in_memberExpression1416 = new BitSet(new ulong[]{0xC000009800000F0UL,0x78000000000UL});
		public static readonly BitSet _memberExpression_in_memberExpression1420 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _LT_in_memberExpression1422 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _arguments_in_memberExpression1426 = new BitSet(new ulong[]{0x2800000000000012UL});
		public static readonly BitSet _LT_in_memberExpression1430 = new BitSet(new ulong[]{0x2800000000000010UL});
		public static readonly BitSet _memberExpressionSuffix_in_memberExpression1434 = new BitSet(new ulong[]{0x2800000000000012UL});
		public static readonly BitSet _indexSuffix_in_memberExpressionSuffix1448 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _propertyReferenceSuffix_in_memberExpressionSuffix1453 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _memberExpression_in_callExpression1464 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _LT_in_callExpression1466 = new BitSet(new ulong[]{0x100000010UL});
		public static readonly BitSet _arguments_in_callExpression1470 = new BitSet(new ulong[]{0x2800000100000012UL});
		public static readonly BitSet _LT_in_callExpression1473 = new BitSet(new ulong[]{0x2800000100000010UL});
		public static readonly BitSet _callExpressionSuffix_in_callExpression1477 = new BitSet(new ulong[]{0x2800000100000012UL});
		public static readonly BitSet _arguments_in_callExpressionSuffix1491 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _indexSuffix_in_callExpressionSuffix1496 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _propertyReferenceSuffix_in_callExpressionSuffix1501 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _32_in_arguments1512 = new BitSet(new ulong[]{0xC00000D800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_arguments1515 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _assignmentExpression_in_arguments1519 = new BitSet(new ulong[]{0x600000010UL});
		public static readonly BitSet _LT_in_arguments1522 = new BitSet(new ulong[]{0x200000010UL});
		public static readonly BitSet _33_in_arguments1526 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_arguments1528 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _assignmentExpression_in_arguments1532 = new BitSet(new ulong[]{0x600000010UL});
		public static readonly BitSet _LT_in_arguments1538 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _34_in_arguments1542 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _59_in_indexSuffix1554 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_indexSuffix1556 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _expression_in_indexSuffix1560 = new BitSet(new ulong[]{0x1000000000000010UL});
		public static readonly BitSet _LT_in_indexSuffix1562 = new BitSet(new ulong[]{0x1000000000000010UL});
		public static readonly BitSet _60_in_indexSuffix1566 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _61_in_propertyReferenceSuffix1579 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _LT_in_propertyReferenceSuffix1581 = new BitSet(new ulong[]{0x30UL});
		public static readonly BitSet _Identifier_in_propertyReferenceSuffix1585 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_assignmentOperator0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logicalORExpression_in_conditionalExpression1652 = new BitSet(new ulong[]{0x12UL,0x200UL});
		public static readonly BitSet _LT_in_conditionalExpression1655 = new BitSet(new ulong[]{0x10UL,0x200UL});
		public static readonly BitSet _73_in_conditionalExpression1659 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_conditionalExpression1661 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _assignmentExpression_in_conditionalExpression1665 = new BitSet(new ulong[]{0x4000000000010UL});
		public static readonly BitSet _LT_in_conditionalExpression1667 = new BitSet(new ulong[]{0x4000000000010UL});
		public static readonly BitSet _50_in_conditionalExpression1671 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_conditionalExpression1673 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _assignmentExpression_in_conditionalExpression1677 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logicalORExpressionNoIn_in_conditionalExpressionNoIn1690 = new BitSet(new ulong[]{0x12UL,0x200UL});
		public static readonly BitSet _LT_in_conditionalExpressionNoIn1693 = new BitSet(new ulong[]{0x10UL,0x200UL});
		public static readonly BitSet _73_in_conditionalExpressionNoIn1697 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_conditionalExpressionNoIn1699 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _assignmentExpressionNoIn_in_conditionalExpressionNoIn1703 = new BitSet(new ulong[]{0x4000000000010UL});
		public static readonly BitSet _LT_in_conditionalExpressionNoIn1705 = new BitSet(new ulong[]{0x4000000000010UL});
		public static readonly BitSet _50_in_conditionalExpressionNoIn1709 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_conditionalExpressionNoIn1711 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _assignmentExpressionNoIn_in_conditionalExpressionNoIn1715 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logicalANDExpression_in_logicalORExpression1728 = new BitSet(new ulong[]{0x12UL,0x400UL});
		public static readonly BitSet _LT_in_logicalORExpression1731 = new BitSet(new ulong[]{0x10UL,0x400UL});
		public static readonly BitSet _74_in_logicalORExpression1735 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_logicalORExpression1737 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _logicalANDExpression_in_logicalORExpression1741 = new BitSet(new ulong[]{0x12UL,0x400UL});
		public static readonly BitSet _logicalANDExpressionNoIn_in_logicalORExpressionNoIn1755 = new BitSet(new ulong[]{0x12UL,0x400UL});
		public static readonly BitSet _LT_in_logicalORExpressionNoIn1758 = new BitSet(new ulong[]{0x10UL,0x400UL});
		public static readonly BitSet _74_in_logicalORExpressionNoIn1762 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_logicalORExpressionNoIn1764 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _logicalANDExpressionNoIn_in_logicalORExpressionNoIn1768 = new BitSet(new ulong[]{0x12UL,0x400UL});
		public static readonly BitSet _bitwiseORExpression_in_logicalANDExpression1782 = new BitSet(new ulong[]{0x12UL,0x800UL});
		public static readonly BitSet _LT_in_logicalANDExpression1785 = new BitSet(new ulong[]{0x10UL,0x800UL});
		public static readonly BitSet _75_in_logicalANDExpression1789 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_logicalANDExpression1791 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _bitwiseORExpression_in_logicalANDExpression1795 = new BitSet(new ulong[]{0x12UL,0x800UL});
		public static readonly BitSet _bitwiseORExpressionNoIn_in_logicalANDExpressionNoIn1809 = new BitSet(new ulong[]{0x12UL,0x800UL});
		public static readonly BitSet _LT_in_logicalANDExpressionNoIn1812 = new BitSet(new ulong[]{0x10UL,0x800UL});
		public static readonly BitSet _75_in_logicalANDExpressionNoIn1816 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_logicalANDExpressionNoIn1818 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _bitwiseORExpressionNoIn_in_logicalANDExpressionNoIn1822 = new BitSet(new ulong[]{0x12UL,0x800UL});
		public static readonly BitSet _bitwiseXORExpression_in_bitwiseORExpression1836 = new BitSet(new ulong[]{0x12UL,0x1000UL});
		public static readonly BitSet _LT_in_bitwiseORExpression1839 = new BitSet(new ulong[]{0x10UL,0x1000UL});
		public static readonly BitSet _76_in_bitwiseORExpression1843 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_bitwiseORExpression1845 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _bitwiseXORExpression_in_bitwiseORExpression1849 = new BitSet(new ulong[]{0x12UL,0x1000UL});
		public static readonly BitSet _bitwiseXORExpressionNoIn_in_bitwiseORExpressionNoIn1863 = new BitSet(new ulong[]{0x12UL,0x1000UL});
		public static readonly BitSet _LT_in_bitwiseORExpressionNoIn1866 = new BitSet(new ulong[]{0x10UL,0x1000UL});
		public static readonly BitSet _76_in_bitwiseORExpressionNoIn1870 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_bitwiseORExpressionNoIn1872 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _bitwiseXORExpressionNoIn_in_bitwiseORExpressionNoIn1876 = new BitSet(new ulong[]{0x12UL,0x1000UL});
		public static readonly BitSet _bitwiseANDExpression_in_bitwiseXORExpression1890 = new BitSet(new ulong[]{0x12UL,0x2000UL});
		public static readonly BitSet _LT_in_bitwiseXORExpression1893 = new BitSet(new ulong[]{0x10UL,0x2000UL});
		public static readonly BitSet _77_in_bitwiseXORExpression1897 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_bitwiseXORExpression1899 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _bitwiseANDExpression_in_bitwiseXORExpression1903 = new BitSet(new ulong[]{0x12UL,0x2000UL});
		public static readonly BitSet _bitwiseANDExpressionNoIn_in_bitwiseXORExpressionNoIn1917 = new BitSet(new ulong[]{0x12UL,0x2000UL});
		public static readonly BitSet _LT_in_bitwiseXORExpressionNoIn1920 = new BitSet(new ulong[]{0x10UL,0x2000UL});
		public static readonly BitSet _77_in_bitwiseXORExpressionNoIn1924 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_bitwiseXORExpressionNoIn1926 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _bitwiseANDExpressionNoIn_in_bitwiseXORExpressionNoIn1930 = new BitSet(new ulong[]{0x12UL,0x2000UL});
		public static readonly BitSet _equalityExpression_in_bitwiseANDExpression1944 = new BitSet(new ulong[]{0x12UL,0x4000UL});
		public static readonly BitSet _LT_in_bitwiseANDExpression1947 = new BitSet(new ulong[]{0x10UL,0x4000UL});
		public static readonly BitSet _78_in_bitwiseANDExpression1951 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_bitwiseANDExpression1953 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _equalityExpression_in_bitwiseANDExpression1957 = new BitSet(new ulong[]{0x12UL,0x4000UL});
		public static readonly BitSet _equalityExpressionNoIn_in_bitwiseANDExpressionNoIn1971 = new BitSet(new ulong[]{0x12UL,0x4000UL});
		public static readonly BitSet _LT_in_bitwiseANDExpressionNoIn1974 = new BitSet(new ulong[]{0x10UL,0x4000UL});
		public static readonly BitSet _78_in_bitwiseANDExpressionNoIn1978 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_bitwiseANDExpressionNoIn1980 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _equalityExpressionNoIn_in_bitwiseANDExpressionNoIn1984 = new BitSet(new ulong[]{0x12UL,0x4000UL});
		public static readonly BitSet _relationalExpression_in_equalityExpression1998 = new BitSet(new ulong[]{0x12UL,0x78000UL});
		public static readonly BitSet _LT_in_equalityExpression2001 = new BitSet(new ulong[]{0x10UL,0x78000UL});
		public static readonly BitSet _set_in_equalityExpression2005 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_equalityExpression2021 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _relationalExpression_in_equalityExpression2025 = new BitSet(new ulong[]{0x12UL,0x78000UL});
		public static readonly BitSet _relationalExpressionNoIn_in_equalityExpressionNoIn2038 = new BitSet(new ulong[]{0x12UL,0x78000UL});
		public static readonly BitSet _LT_in_equalityExpressionNoIn2041 = new BitSet(new ulong[]{0x10UL,0x78000UL});
		public static readonly BitSet _set_in_equalityExpressionNoIn2045 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_equalityExpressionNoIn2061 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _relationalExpressionNoIn_in_equalityExpressionNoIn2065 = new BitSet(new ulong[]{0x12UL,0x78000UL});
		public static readonly BitSet _shiftExpression_in_relationalExpression2079 = new BitSet(new ulong[]{0x200000000012UL,0xF80000UL});
		public static readonly BitSet _LT_in_relationalExpression2082 = new BitSet(new ulong[]{0x200000000010UL,0xF80000UL});
		public static readonly BitSet _set_in_relationalExpression2086 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_relationalExpression2110 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _shiftExpression_in_relationalExpression2114 = new BitSet(new ulong[]{0x200000000012UL,0xF80000UL});
		public static readonly BitSet _shiftExpression_in_relationalExpressionNoIn2127 = new BitSet(new ulong[]{0x12UL,0xF80000UL});
		public static readonly BitSet _LT_in_relationalExpressionNoIn2130 = new BitSet(new ulong[]{0x10UL,0xF80000UL});
		public static readonly BitSet _set_in_relationalExpressionNoIn2134 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_relationalExpressionNoIn2154 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _shiftExpression_in_relationalExpressionNoIn2158 = new BitSet(new ulong[]{0x12UL,0xF80000UL});
		public static readonly BitSet _additiveExpression_in_shiftExpression2171 = new BitSet(new ulong[]{0x12UL,0x7000000UL});
		public static readonly BitSet _LT_in_shiftExpression2174 = new BitSet(new ulong[]{0x10UL,0x7000000UL});
		public static readonly BitSet _set_in_shiftExpression2178 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_shiftExpression2190 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _additiveExpression_in_shiftExpression2194 = new BitSet(new ulong[]{0x12UL,0x7000000UL});
		public static readonly BitSet _multiplicativeExpression_in_additiveExpression2207 = new BitSet(new ulong[]{0x12UL,0x18000000UL});
		public static readonly BitSet _LT_in_additiveExpression2210 = new BitSet(new ulong[]{0x10UL,0x18000000UL});
		public static readonly BitSet _set_in_additiveExpression2214 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_additiveExpression2222 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _multiplicativeExpression_in_additiveExpression2226 = new BitSet(new ulong[]{0x12UL,0x18000000UL});
		public static readonly BitSet _unaryExpression_in_multiplicativeExpression2239 = new BitSet(new ulong[]{0x12UL,0xE0000000UL});
		public static readonly BitSet _LT_in_multiplicativeExpression2242 = new BitSet(new ulong[]{0x10UL,0xE0000000UL});
		public static readonly BitSet _set_in_multiplicativeExpression2246 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_multiplicativeExpression2258 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _unaryExpression_in_multiplicativeExpression2262 = new BitSet(new ulong[]{0x12UL,0xE0000000UL});
		public static readonly BitSet _postfixExpression_in_unaryExpression2275 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_unaryExpression2280 = new BitSet(new ulong[]{0xC000009800000E0UL,0x7FF18000000UL});
		public static readonly BitSet _unaryExpression_in_unaryExpression2316 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _leftHandSideExpression_in_postfixExpression2328 = new BitSet(new ulong[]{0x2UL,0x1800000000UL});
		public static readonly BitSet _set_in_postfixExpression2330 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _103_in_primaryExpression2348 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Identifier_in_primaryExpression2353 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _literal_in_primaryExpression2358 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayLiteral_in_primaryExpression2363 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objectLiteral_in_primaryExpression2368 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _32_in_primaryExpression2373 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_primaryExpression2375 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _expression_in_primaryExpression2379 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _LT_in_primaryExpression2381 = new BitSet(new ulong[]{0x400000010UL});
		public static readonly BitSet _34_in_primaryExpression2385 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _59_in_arrayLiteral2398 = new BitSet(new ulong[]{0x1C00000B800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_arrayLiteral2400 = new BitSet(new ulong[]{0x1C00000B800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _assignmentExpression_in_arrayLiteral2404 = new BitSet(new ulong[]{0x1000000200000010UL});
		public static readonly BitSet _LT_in_arrayLiteral2408 = new BitSet(new ulong[]{0x200000010UL});
		public static readonly BitSet _33_in_arrayLiteral2412 = new BitSet(new ulong[]{0x1C00000B800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_arrayLiteral2415 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _assignmentExpression_in_arrayLiteral2419 = new BitSet(new ulong[]{0x1000000200000010UL});
		public static readonly BitSet _LT_in_arrayLiteral2425 = new BitSet(new ulong[]{0x1000000000000010UL});
		public static readonly BitSet _60_in_arrayLiteral2429 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _35_in_objectLiteral2448 = new BitSet(new ulong[]{0xF0UL});
		public static readonly BitSet _LT_in_objectLiteral2450 = new BitSet(new ulong[]{0xF0UL});
		public static readonly BitSet _propertyNameAndValue_in_objectLiteral2454 = new BitSet(new ulong[]{0x1200000010UL});
		public static readonly BitSet _LT_in_objectLiteral2457 = new BitSet(new ulong[]{0x200000010UL});
		public static readonly BitSet _33_in_objectLiteral2461 = new BitSet(new ulong[]{0xF0UL});
		public static readonly BitSet _LT_in_objectLiteral2463 = new BitSet(new ulong[]{0xF0UL});
		public static readonly BitSet _propertyNameAndValue_in_objectLiteral2467 = new BitSet(new ulong[]{0x1200000010UL});
		public static readonly BitSet _LT_in_objectLiteral2471 = new BitSet(new ulong[]{0x1000000010UL});
		public static readonly BitSet _36_in_objectLiteral2475 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _propertyName_in_propertyNameAndValue2487 = new BitSet(new ulong[]{0x4000000000010UL});
		public static readonly BitSet _LT_in_propertyNameAndValue2489 = new BitSet(new ulong[]{0x4000000000010UL});
		public static readonly BitSet _50_in_propertyNameAndValue2493 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_propertyNameAndValue2495 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _assignmentExpression_in_propertyNameAndValue2499 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_propertyName0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_literal0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _functionDeclaration_in_synpred5_JavaScript93 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LT_in_synpred9_JavaScript143 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statementBlock_in_synpred21_JavaScript237 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expressionStatement_in_synpred24_JavaScript252 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _labelledStatement_in_synpred31_JavaScript287 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LT_in_synpred34_JavaScript316 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LT_in_synpred47_JavaScript443 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LT_in_synpred49_JavaScript462 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LT_in_synpred60_JavaScript575 = new BitSet(new ulong[]{0x20000000010UL});
		public static readonly BitSet _41_in_synpred60_JavaScript579 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_synpred60_JavaScript581 = new BitSet(new ulong[]{0xCCBDD69800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _statement_in_synpred60_JavaScript585 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forStatement_in_synpred63_JavaScript609 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LT_in_synpred118_JavaScript1090 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LT_in_synpred121_JavaScript1115 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _conditionalExpression_in_synpred140_JavaScript1307 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _conditionalExpressionNoIn_in_synpred143_JavaScript1336 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _callExpression_in_synpred146_JavaScript1365 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _memberExpression_in_synpred147_JavaScript1382 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LT_in_synpred154_JavaScript1430 = new BitSet(new ulong[]{0x2800000000000010UL});
		public static readonly BitSet _memberExpressionSuffix_in_synpred154_JavaScript1434 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LT_in_synpred158_JavaScript1473 = new BitSet(new ulong[]{0x2800000100000010UL});
		public static readonly BitSet _callExpressionSuffix_in_synpred158_JavaScript1477 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LT_in_synpred256_JavaScript2210 = new BitSet(new ulong[]{0x10UL,0x18000000UL});
		public static readonly BitSet _set_in_synpred256_JavaScript2214 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _LT_in_synpred256_JavaScript2222 = new BitSet(new ulong[]{0xC000009800000F0UL,0x7FF18000000UL});
		public static readonly BitSet _multiplicativeExpression_in_synpred256_JavaScript2226 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LT_in_synpred280_JavaScript2400 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  Sudio.NET.Parser 
