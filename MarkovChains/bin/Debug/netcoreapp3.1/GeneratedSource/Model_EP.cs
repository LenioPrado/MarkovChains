// <auto-generated />
#pragma warning disable 1570, 1591

using System;
using Microsoft.ML.Probabilistic;
using Microsoft.ML.Probabilistic.Distributions;
using Microsoft.ML.Probabilistic.Factors;

namespace Models
{
	/// <summary>
	/// Generated algorithm for performing inference.
	/// </summary>
	/// <remarks>
	/// If you wish to use this class directly, you must perform the following steps:
	/// 1) Create an instance of the class.
	/// 2) Set the value of any externally-set fields e.g. data, priors.
	/// 3) Call the Execute(numberOfIterations) method.
	/// 4) Use the XXXMarginal() methods to retrieve posterior marginals for different variables.
	/// 
	/// Generated by Infer.NET 0.3.2102.1701 at 16:06 on quarta-feira, 29 de dezembro de 2021.
	/// </remarks>
	public partial class Model_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>True if Changed_numberOfIterations_vdouble__0_vGamma0_vGaussian0_vint0 has executed. Set this to false to force re-execution of Changed_numberOfIterations_vdouble__0_vGamma0_vGaussian0_vint0</summary>
		public bool Changed_numberOfIterations_vdouble__0_vGamma0_vGaussian0_vint0_isDone;
		/// <summary>True if Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0 has executed. Set this to false to force re-execution of Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0</summary>
		public bool Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0_isDone;
		/// <summary>True if Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0 has performed initialisation. Set this to false to force re-execution of Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0</summary>
		public bool Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0_isInitialised;
		/// <summary>True if Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0 has executed. Set this to false to force re-execution of Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0</summary>
		public bool Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0_isDone;
		/// <summary>True if Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0 has performed initialisation. Set this to false to force re-execution of Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0</summary>
		public bool Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0_isInitialised;
		/// <summary>True if Changed_vdouble__0_vint0 has executed. Set this to false to force re-execution of Changed_vdouble__0_vint0</summary>
		public bool Changed_vdouble__0_vint0_isDone;
		/// <summary>True if Changed_vGamma0 has executed. Set this to false to force re-execution of Changed_vGamma0</summary>
		public bool Changed_vGamma0_isDone;
		/// <summary>True if Changed_vGaussian0 has executed. Set this to false to force re-execution of Changed_vGaussian0</summary>
		public bool Changed_vGaussian0_isDone;
		/// <summary>True if Changed_vint0 has executed. Set this to false to force re-execution of Changed_vint0</summary>
		public bool Changed_vint0_isDone;
		/// <summary>True if Constant has executed. Set this to false to force re-execution of Constant</summary>
		public bool Constant_isDone;
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vdouble__0 property</summary>
		private double[] Vdouble__0;
		/// <summary>Message to marginal of 'vdouble__0'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__0_marginal_F;
		/// <summary>Message to marginal of 'vdouble0'</summary>
		public Gaussian vdouble0_marginal_F;
		public Gaussian[] vdouble0_rep_F;
		/// <summary>Message to marginal of 'vdouble1'</summary>
		public Gamma vdouble1_marginal_F;
		public Gamma[] vdouble1_rep_B;
		/// <summary>Buffer for ReplicateOp_Divide.Marginal&lt;Gamma&gt;</summary>
		public Gamma vdouble1_rep_B_toDef;
		/// <summary>Field backing the vGamma0 property</summary>
		private Gamma VGamma0;
		/// <summary>Message to marginal of 'vGamma0'</summary>
		public PointMass<Gamma> vGamma0_marginal_F;
		/// <summary>Field backing the vGaussian0 property</summary>
		private Gaussian VGaussian0;
		/// <summary>Message to marginal of 'vGaussian0'</summary>
		public PointMass<Gaussian> vGaussian0_marginal_F;
		/// <summary>Field backing the vint0 property</summary>
		private int Vint0;
		/// <summary>Message to marginal of 'vint0'</summary>
		public PointMass<int> vint0_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__0'</summary>
		public double[] vdouble__0
		{
			get {
				return this.Vdouble__0;
			}
			set {
				if ((value!=null)&&(value.Length!=this.Vint0)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+this.Vint0)+" was expected for variable \'vdouble__0\'");
				}
				this.Vdouble__0 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vdouble__0_vint0_isDone = false;
				this.Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0_isInitialised = false;
				this.Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0_isInitialised = false;
				this.Changed_numberOfIterations_vdouble__0_vGamma0_vGaussian0_vint0_isDone = false;
			}
		}

		/// <summary>The externally-specified value of 'vGamma0'</summary>
		public Gamma vGamma0
		{
			get {
				return this.VGamma0;
			}
			set {
				if (this.VGamma0!=value) {
					this.VGamma0 = value;
					this.numberOfIterationsDone = 0;
					this.Changed_vGamma0_isDone = false;
					this.Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0_isDone = false;
					this.Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0_isInitialised = false;
					this.Changed_numberOfIterations_vdouble__0_vGamma0_vGaussian0_vint0_isDone = false;
				}
			}
		}

		/// <summary>The externally-specified value of 'vGaussian0'</summary>
		public Gaussian vGaussian0
		{
			get {
				return this.VGaussian0;
			}
			set {
				if (this.VGaussian0!=value) {
					this.VGaussian0 = value;
					this.numberOfIterationsDone = 0;
					this.Changed_vGaussian0_isDone = false;
					this.Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0_isInitialised = false;
					this.Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0_isInitialised = false;
					this.Changed_numberOfIterations_vdouble__0_vGamma0_vGaussian0_vint0_isDone = false;
				}
			}
		}

		/// <summary>The externally-specified value of 'vint0'</summary>
		public int vint0
		{
			get {
				return this.Vint0;
			}
			set {
				if (this.Vint0!=value) {
					this.Vint0 = value;
					this.numberOfIterationsDone = 0;
					this.Changed_vdouble__0_vint0_isDone = false;
					this.Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0_isInitialised = false;
					this.Changed_vint0_isDone = false;
					this.Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0_isDone = false;
					this.Changed_numberOfIterations_vdouble__0_vGamma0_vGaussian0_vint0_isDone = false;
				}
			}
		}

		#endregion

		#region Methods
		/// <summary>Computations that depend on the observed value of numberOfIterations and vdouble__0 and vGamma0 and vGaussian0 and vint0</summary>
		/// <param name="numberOfIterations">The number of times to iterate each loop</param>
		private void Changed_numberOfIterations_vdouble__0_vGamma0_vGaussian0_vint0(int numberOfIterations)
		{
			if (this.Changed_numberOfIterations_vdouble__0_vGamma0_vGaussian0_vint0_isDone) {
				return ;
			}
			this.vdouble0_marginal_F = Gaussian.Uniform();
			Gaussian vdouble0_rep_F_marginal;
			// Message to 'vdouble0_rep' from Replicate factor
			vdouble0_rep_F_marginal = ReplicateOp_Divide.MarginalInit<Gaussian>(this.VGaussian0);
			Gamma vdouble1_rep_F_marginal;
			// Message to 'vdouble1_rep' from Replicate factor
			vdouble1_rep_F_marginal = ReplicateOp_Divide.MarginalInit<Gamma>(this.VGamma0);
			Gamma[] vdouble1_rep_F;
			// Create array for 'vdouble1_rep' Forwards messages.
			vdouble1_rep_F = new Gamma[this.Vint0];
			for(int index0 = 0; index0<this.Vint0; index0++) {
				vdouble1_rep_F[index0] = Gamma.Uniform();
			}
			Gaussian[] vdouble0_rep_B;
			// Create array for 'vdouble0_rep' Backwards messages.
			vdouble0_rep_B = new Gaussian[this.Vint0];
			for(int index0 = 0; index0<this.Vint0; index0++) {
				vdouble0_rep_B[index0] = Gaussian.Uniform();
			}
			Gaussian vdouble0_rep_B_toDef;
			// Message to 'vdouble0_rep' from Replicate factor
			vdouble0_rep_B_toDef = ReplicateOp_Divide.ToDefInit<Gaussian>(this.VGaussian0);
			for(int iteration = this.numberOfIterationsDone; iteration<numberOfIterations; iteration++) {
				// Message to 'vdouble1_rep' from Replicate factor
				vdouble1_rep_F_marginal = ReplicateOp_Divide.Marginal<Gamma>(this.vdouble1_rep_B_toDef, this.VGamma0, vdouble1_rep_F_marginal);
				for(int index0 = 0; index0<this.Vint0; index0++) {
					// Message to 'vdouble1_rep' from Replicate factor
					vdouble1_rep_F[index0] = ReplicateOp_Divide.UsesAverageConditional<Gamma>(this.vdouble1_rep_B[index0], vdouble1_rep_F_marginal, index0, vdouble1_rep_F[index0]);
					// Message to 'vdouble0_rep' from Gaussian factor
					vdouble0_rep_B[index0] = GaussianOp.MeanAverageConditional(this.Vdouble__0[index0], this.vdouble0_rep_F[index0], vdouble1_rep_F[index0], this.vdouble1_rep_B[index0]);
				}
				// Message to 'vdouble0_rep' from Replicate factor
				vdouble0_rep_B_toDef = ReplicateOp_Divide.ToDef<Gaussian>(vdouble0_rep_B, vdouble0_rep_B_toDef);
				// Message to 'vdouble0_rep' from Replicate factor
				vdouble0_rep_F_marginal = ReplicateOp_Divide.Marginal<Gaussian>(vdouble0_rep_B_toDef, this.VGaussian0, vdouble0_rep_F_marginal);
				for(int index0 = 0; index0<this.Vint0; index0++) {
					// Message to 'vdouble0_rep' from Replicate factor
					this.vdouble0_rep_F[index0] = ReplicateOp_Divide.UsesAverageConditional<Gaussian>(vdouble0_rep_B[index0], vdouble0_rep_F_marginal, index0, this.vdouble0_rep_F[index0]);
					// Message to 'vdouble1_rep' from Gaussian factor
					this.vdouble1_rep_B[index0] = GaussianOp.PrecisionAverageConditional(Gaussian.PointMass(this.Vdouble__0[index0]), this.vdouble0_rep_F[index0], vdouble1_rep_F[index0]);
				}
				// Message to 'vdouble1_rep' from Replicate factor
				this.vdouble1_rep_B_toDef = ReplicateOp_Divide.ToDef<Gamma>(this.vdouble1_rep_B, this.vdouble1_rep_B_toDef);
				this.OnProgressChanged(new ProgressChangedEventArgs(iteration));
			}
			// Message to 'vdouble0_marginal' from Variable factor
			this.vdouble0_marginal_F = VariableOp.MarginalAverageConditional<Gaussian>(vdouble0_rep_B_toDef, this.VGaussian0, this.vdouble0_marginal_F);
			this.vdouble1_marginal_F = Gamma.Uniform();
			// Message to 'vdouble1_marginal' from Variable factor
			this.vdouble1_marginal_F = VariableOp.MarginalAverageConditional<Gamma>(this.vdouble1_rep_B_toDef, this.VGamma0, this.vdouble1_marginal_F);
			this.Changed_numberOfIterations_vdouble__0_vGamma0_vGaussian0_vint0_isDone = true;
		}

		/// <summary>Computations that depend on the observed value of numberOfIterationsDecreased and vGamma0 and must reset on changes to vdouble__0 and vGaussian0 and vint0</summary>
		/// <param name="initialise">If true, reset messages that initialise loops</param>
		private void Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0(bool initialise)
		{
			if (this.Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0_isDone&&((!initialise)||this.Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0_isInitialised)) {
				return ;
			}
			// Message to 'vdouble1_rep' from Replicate factor
			this.vdouble1_rep_B_toDef = ReplicateOp_Divide.ToDefInit<Gamma>(this.VGamma0);
			this.Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0_isDone = true;
			this.Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0_isInitialised = true;
		}

		/// <summary>Computations that depend on the observed value of numberOfIterationsDecreased and vint0 and must reset on changes to vdouble__0 and vGamma0 and vGaussian0</summary>
		/// <param name="initialise">If true, reset messages that initialise loops</param>
		private void Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0(bool initialise)
		{
			if (this.Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0_isDone&&((!initialise)||this.Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0_isInitialised)) {
				return ;
			}
			for(int index0 = 0; index0<this.Vint0; index0++) {
				this.vdouble0_rep_F[index0] = Gaussian.Uniform();
				this.vdouble1_rep_B[index0] = Gamma.Uniform();
			}
			this.Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0_isDone = true;
			this.Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0_isInitialised = true;
		}

		/// <summary>Computations that depend on the observed value of vdouble__0 and vint0</summary>
		private void Changed_vdouble__0_vint0()
		{
			if (this.Changed_vdouble__0_vint0_isDone) {
				return ;
			}
			// Create array for 'vdouble__0_marginal' Forwards messages.
			this.vdouble__0_marginal_F = new DistributionStructArray<Gaussian,double>(this.Vint0);
			for(int index0 = 0; index0<this.Vint0; index0++) {
				this.vdouble__0_marginal_F[index0] = Gaussian.Uniform();
			}
			// Message to 'vdouble__0_marginal' from DerivedVariable factor
			this.vdouble__0_marginal_F = DerivedVariableOp.MarginalAverageConditional<DistributionStructArray<Gaussian,double>,double[]>(this.Vdouble__0, this.vdouble__0_marginal_F);
			this.Changed_vdouble__0_vint0_isDone = true;
		}

		/// <summary>Computations that depend on the observed value of vGamma0</summary>
		private void Changed_vGamma0()
		{
			if (this.Changed_vGamma0_isDone) {
				return ;
			}
			this.vGamma0_marginal_F = new PointMass<Gamma>(this.VGamma0);
			// Message to 'vGamma0_marginal' from DerivedVariable factor
			this.vGamma0_marginal_F = DerivedVariableOp.MarginalAverageConditional<PointMass<Gamma>,Gamma>(this.VGamma0, this.vGamma0_marginal_F);
			this.Changed_vGamma0_isDone = true;
		}

		/// <summary>Computations that depend on the observed value of vGaussian0</summary>
		private void Changed_vGaussian0()
		{
			if (this.Changed_vGaussian0_isDone) {
				return ;
			}
			this.vGaussian0_marginal_F = new PointMass<Gaussian>(this.VGaussian0);
			// Message to 'vGaussian0_marginal' from DerivedVariable factor
			this.vGaussian0_marginal_F = DerivedVariableOp.MarginalAverageConditional<PointMass<Gaussian>,Gaussian>(this.VGaussian0, this.vGaussian0_marginal_F);
			this.Changed_vGaussian0_isDone = true;
		}

		/// <summary>Computations that depend on the observed value of vint0</summary>
		private void Changed_vint0()
		{
			if (this.Changed_vint0_isDone) {
				return ;
			}
			// Create array for 'vdouble0_rep' Forwards messages.
			this.vdouble0_rep_F = new Gaussian[this.Vint0];
			// Create array for 'vdouble1_rep' Backwards messages.
			this.vdouble1_rep_B = new Gamma[this.Vint0];
			this.vint0_marginal_F = new PointMass<int>(this.Vint0);
			// Message to 'vint0_marginal' from DerivedVariable factor
			this.vint0_marginal_F = DerivedVariableOp.MarginalAverageConditional<PointMass<int>,int>(this.Vint0, this.vint0_marginal_F);
			this.Changed_vint0_isDone = true;
		}

		/// <summary>Computations that do not depend on observed values</summary>
		private void Constant()
		{
			if (this.Constant_isDone) {
				return ;
			}
			this.Constant_isDone = true;
		}

		/// <summary>Update all marginals, by iterating message passing the given number of times</summary>
		/// <param name="numberOfIterations">The number of times to iterate each loop</param>
		/// <param name="initialise">If true, messages that initialise loops are reset when observed values change</param>
		private void Execute(int numberOfIterations, bool initialise)
		{
			if (numberOfIterations!=this.numberOfIterationsDone) {
				if (numberOfIterations<this.numberOfIterationsDone) {
					this.numberOfIterationsDone = 0;
					this.Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0_isDone = false;
					this.Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0_isDone = false;
				}
				this.Changed_numberOfIterations_vdouble__0_vGamma0_vGaussian0_vint0_isDone = false;
			}
			this.Changed_vdouble__0_vint0();
			this.Changed_vGamma0();
			this.Changed_vGaussian0();
			this.Constant();
			this.Changed_numberOfIterationsDecreased_vGamma0_Init_vdouble__0_vGaussian0_vint0(initialise);
			this.Changed_vint0();
			this.Changed_numberOfIterationsDecreased_vint0_Init_vdouble__0_vGamma0_vGaussian0(initialise);
			this.Changed_numberOfIterations_vdouble__0_vGamma0_vGaussian0_vint0(numberOfIterations);
			this.numberOfIterationsDone = numberOfIterations;
		}

		/// <summary>Update all marginals, by iterating message-passing the given number of times</summary>
		/// <param name="numberOfIterations">The total number of iterations that should be executed for the current set of observed values.  If this is more than the number already done, only the extra iterations are done.  If this is less than the number already done, message-passing is restarted from the beginning.  Changing the observed values resets the iteration count to 0.</param>
		public void Execute(int numberOfIterations)
		{
			this.Execute(numberOfIterations, true);
		}

		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vGaussian0") {
				return this.vGaussian0;
			}
			if (variableName=="vGamma0") {
				return this.vGamma0;
			}
			if (variableName=="vint0") {
				return this.vint0;
			}
			if (variableName=="vdouble__0") {
				return this.vdouble__0;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Get the marginal distribution (computed up to this point) of a variable</summary>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <returns>The marginal distribution computed up to this point</returns>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public object Marginal(string variableName)
		{
			if (variableName=="vdouble__0") {
				return this.Vdouble__0Marginal();
			}
			if (variableName=="vGamma0") {
				return this.VGamma0Marginal();
			}
			if (variableName=="vGaussian0") {
				return this.VGaussian0Marginal();
			}
			if (variableName=="vint0") {
				return this.Vint0Marginal();
			}
			if (variableName=="vdouble0") {
				return this.Vdouble0Marginal();
			}
			if (variableName=="vdouble1") {
				return this.Vdouble1Marginal();
			}
			throw new ArgumentException("This class was not built to infer "+variableName);
		}

		/// <summary>Get the marginal distribution (computed up to this point) of a variable, converted to type T</summary>
		/// <typeparam name="T">The distribution type.</typeparam>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <returns>The marginal distribution computed up to this point</returns>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public T Marginal<T>(string variableName)
		{
			return Distribution.ChangeType<T>(this.Marginal(variableName));
		}

		/// <summary>Get the query-specific marginal distribution of a variable.</summary>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <param name="query">QueryType name. For example, GibbsSampling answers 'Marginal', 'Samples', and 'Conditionals' queries</param>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public object Marginal(string variableName, string query)
		{
			if (query=="Marginal") {
				return this.Marginal(variableName);
			}
			throw new ArgumentException(((("This class was not built to infer \'"+variableName)+"\' with query \'")+query)+"\'");
		}

		/// <summary>Get the query-specific marginal distribution of a variable, converted to type T</summary>
		/// <typeparam name="T">The distribution type.</typeparam>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <param name="query">QueryType name. For example, GibbsSampling answers 'Marginal', 'Samples', and 'Conditionals' queries</param>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public T Marginal<T>(string variableName, string query)
		{
			return Distribution.ChangeType<T>(this.Marginal(variableName, query));
		}

		private void OnProgressChanged(ProgressChangedEventArgs e)
		{
			// Make a temporary copy of the event to avoid a race condition
			// if the last subscriber unsubscribes immediately after the null check and before the event is raised.
			EventHandler<ProgressChangedEventArgs> handler = this.ProgressChanged;
			if (handler!=null) {
				handler(this, e);
			}
		}

		/// <summary>Reset all messages to their initial values.  Sets NumberOfIterationsDone to 0.</summary>
		public void Reset()
		{
			this.Execute(0);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vGaussian0") {
				this.vGaussian0 = (Gaussian)value;
				return ;
			}
			if (variableName=="vGamma0") {
				this.vGamma0 = (Gamma)value;
				return ;
			}
			if (variableName=="vint0") {
				this.vint0 = (int)value;
				return ;
			}
			if (variableName=="vdouble__0") {
				this.vdouble__0 = (double[])value;
				return ;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Update all marginals, by iterating message-passing an additional number of times</summary>
		/// <param name="additionalIterations">The number of iterations that should be executed, starting from the current message state.  Messages are not reset, even if observed values have changed.</param>
		public void Update(int additionalIterations)
		{
			this.Execute(checked(this.numberOfIterationsDone+additionalIterations), false);
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__0' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__0Marginal()
		{
			return this.vdouble__0_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble0' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Gaussian Vdouble0Marginal()
		{
			return this.vdouble0_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble1' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Gamma Vdouble1Marginal()
		{
			return this.vdouble1_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vGamma0' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Gamma> VGamma0Marginal()
		{
			return this.vGamma0_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vGaussian0' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Gaussian> VGaussian0Marginal()
		{
			return this.vGaussian0_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vint0' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<int> Vint0Marginal()
		{
			return this.vint0_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}