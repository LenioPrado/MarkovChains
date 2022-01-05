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
	/// Generated by Infer.NET 0.3.2102.1701 at 17:53 on terça-feira, 28 de dezembro de 2021.
	/// </remarks>
	public partial class Model3_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>True if Changed_vGamma1 has executed. Set this to false to force re-execution of Changed_vGamma1</summary>
		public bool Changed_vGamma1_isDone;
		/// <summary>True if Changed_vGamma1_vGaussian1 has executed. Set this to false to force re-execution of Changed_vGamma1_vGaussian1</summary>
		public bool Changed_vGamma1_vGaussian1_isDone;
		/// <summary>True if Changed_vGaussian1 has executed. Set this to false to force re-execution of Changed_vGaussian1</summary>
		public bool Changed_vGaussian1_isDone;
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Message to marginal of 'vbool0'</summary>
		public Bernoulli vbool0_marginal_F;
		/// <summary>Message to marginal of 'vbool1'</summary>
		public Bernoulli vbool1_marginal_F;
		/// <summary>Message to marginal of 'vbool2'</summary>
		public Bernoulli vbool2_marginal_F;
		/// <summary>Message to marginal of 'vdouble11'</summary>
		public Gaussian vdouble11_marginal_F;
		/// <summary>Message to marginal of 'vdouble13'</summary>
		public Gaussian vdouble13_marginal_F;
		/// <summary>Message to marginal of 'vdouble5'</summary>
		public Gaussian vdouble5_marginal_F;
		/// <summary>Message to marginal of 'vdouble6'</summary>
		public Gamma vdouble6_marginal_F;
		/// <summary>Message to marginal of 'vdouble7'</summary>
		public Gaussian vdouble7_marginal_F;
		/// <summary>Message to marginal of 'vdouble9'</summary>
		public Gaussian vdouble9_marginal_F;
		/// <summary>Field backing the vGamma1 property</summary>
		private Gamma VGamma1;
		/// <summary>Message to marginal of 'vGamma1'</summary>
		public PointMass<Gamma> vGamma1_marginal_F;
		/// <summary>Field backing the vGaussian1 property</summary>
		private Gaussian VGaussian1;
		/// <summary>Message to marginal of 'vGaussian1'</summary>
		public PointMass<Gaussian> vGaussian1_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vGamma1'</summary>
		public Gamma vGamma1
		{
			get {
				return this.VGamma1;
			}
			set {
				if (this.VGamma1!=value) {
					this.VGamma1 = value;
					this.numberOfIterationsDone = 0;
					this.Changed_vGamma1_isDone = false;
					this.Changed_vGamma1_vGaussian1_isDone = false;
				}
			}
		}

		/// <summary>The externally-specified value of 'vGaussian1'</summary>
		public Gaussian vGaussian1
		{
			get {
				return this.VGaussian1;
			}
			set {
				if (this.VGaussian1!=value) {
					this.VGaussian1 = value;
					this.numberOfIterationsDone = 0;
					this.Changed_vGamma1_vGaussian1_isDone = false;
					this.Changed_vGaussian1_isDone = false;
				}
			}
		}

		#endregion

		#region Methods
		/// <summary>Computations that depend on the observed value of vGamma1</summary>
		private void Changed_vGamma1()
		{
			if (this.Changed_vGamma1_isDone) {
				return ;
			}
			this.vGamma1_marginal_F = new PointMass<Gamma>(this.VGamma1);
			// Message to 'vGamma1_marginal' from DerivedVariable factor
			this.vGamma1_marginal_F = DerivedVariableOp.MarginalAverageConditional<PointMass<Gamma>,Gamma>(this.VGamma1, this.vGamma1_marginal_F);
			this.Changed_vGamma1_isDone = true;
		}

		/// <summary>Computations that depend on the observed value of vGamma1 and vGaussian1</summary>
		private void Changed_vGamma1_vGaussian1()
		{
			if (this.Changed_vGamma1_vGaussian1_isDone) {
				return ;
			}
			this.vdouble6_marginal_F = Gamma.Uniform();
			Gamma vdouble6_use_B = Gamma.Uniform();
			// Message to 'vdouble6_marginal' from Variable factor
			this.vdouble6_marginal_F = VariableOp.MarginalAverageConditional<Gamma>(vdouble6_use_B, this.VGamma1, this.vdouble6_marginal_F);
			Gaussian vdouble7_F = Gaussian.Uniform();
			this.vdouble7_marginal_F = Gaussian.Uniform();
			Gaussian vdouble7_uses_B_toDef;
			// Message to 'vdouble7_uses' from Replicate factor
			vdouble7_uses_B_toDef = ReplicateOp_Divide.ToDefInit<Gaussian>(vdouble7_F);
			Gaussian vdouble7_uses_F_marginal;
			// Message to 'vdouble7_uses' from Replicate factor
			vdouble7_uses_F_marginal = ReplicateOp_Divide.MarginalInit<Gaussian>(vdouble7_F);
			// Message to 'vdouble7' from Gaussian factor
			vdouble7_F = GaussianOp.SampleAverageConditional(vdouble7_uses_B_toDef, this.VGaussian1, this.VGamma1, vdouble6_use_B);
			Gaussian[] vdouble7_uses_F;
			Gaussian[] vdouble7_uses_B;
			// Create array for 'vdouble7_uses' Forwards messages.
			vdouble7_uses_F = new Gaussian[3];
			// Create array for 'vdouble7_uses' Backwards messages.
			vdouble7_uses_B = new Gaussian[3];
			vdouble7_uses_B[2] = Gaussian.Uniform();
			vdouble7_uses_B[1] = Gaussian.Uniform();
			vdouble7_uses_B[0] = Gaussian.Uniform();
			vdouble7_uses_F[2] = Gaussian.Uniform();
			vdouble7_uses_F[1] = Gaussian.Uniform();
			vdouble7_uses_F[0] = Gaussian.Uniform();
			// Message to 'vdouble7_marginal' from Variable factor
			this.vdouble7_marginal_F = VariableOp.MarginalAverageConditional<Gaussian>(vdouble7_uses_B_toDef, vdouble7_F, this.vdouble7_marginal_F);
			// Message to 'vdouble7_uses' from Replicate factor
			vdouble7_uses_F_marginal = ReplicateOp_Divide.Marginal<Gaussian>(vdouble7_uses_B_toDef, vdouble7_F, vdouble7_uses_F_marginal);
			// Message to 'vdouble7_uses' from Replicate factor
			vdouble7_uses_F[0] = ReplicateOp_Divide.UsesAverageConditional<Gaussian>(vdouble7_uses_B[0], vdouble7_uses_F_marginal, 0, vdouble7_uses_F[0]);
			// Message to 'vdouble7_uses' from Replicate factor
			vdouble7_uses_F[1] = ReplicateOp_Divide.UsesAverageConditional<Gaussian>(vdouble7_uses_B[1], vdouble7_uses_F_marginal, 1, vdouble7_uses_F[1]);
			// Message to 'vdouble7_uses' from Replicate factor
			vdouble7_uses_F[2] = ReplicateOp_Divide.UsesAverageConditional<Gaussian>(vdouble7_uses_B[2], vdouble7_uses_F_marginal, 2, vdouble7_uses_F[2]);
			Gaussian vdouble9_F = default(Gaussian);
			this.vdouble9_marginal_F = Gaussian.Uniform();
			Gaussian vdouble9_use_B = Gaussian.Uniform();
			// Message to 'vdouble9' from Difference factor
			vdouble9_F = DoublePlusOp.AAverageConditional(18.0, vdouble7_uses_F[0]);
			// Message to 'vdouble9_marginal' from DerivedVariable factor
			this.vdouble9_marginal_F = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble9_use_B, vdouble9_F, this.vdouble9_marginal_F);
			Bernoulli vbool0_F = default(Bernoulli);
			this.vbool0_marginal_F = Bernoulli.Uniform();
			Bernoulli vbool0_use_B = Bernoulli.Uniform();
			// Message to 'vbool0' from IsPositive factor
			vbool0_F = IsPositiveOp.IsPositiveAverageConditional(vdouble9_F);
			// Message to 'vbool0_marginal' from DerivedVariable factor
			this.vbool0_marginal_F = DerivedVariableOp.MarginalAverageConditional<Bernoulli>(vbool0_use_B, vbool0_F, this.vbool0_marginal_F);
			Gaussian vdouble11_F = default(Gaussian);
			this.vdouble11_marginal_F = Gaussian.Uniform();
			Gaussian vdouble11_use_B = Gaussian.Uniform();
			// Message to 'vdouble11' from Difference factor
			vdouble11_F = DoublePlusOp.AAverageConditional(18.0, vdouble7_uses_F[1]);
			// Message to 'vdouble11_marginal' from DerivedVariable factor
			this.vdouble11_marginal_F = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble11_use_B, vdouble11_F, this.vdouble11_marginal_F);
			Bernoulli vbool1_F = default(Bernoulli);
			this.vbool1_marginal_F = Bernoulli.Uniform();
			Bernoulli vbool1_use_B = Bernoulli.Uniform();
			// Message to 'vbool1' from IsPositive factor
			vbool1_F = IsPositiveOp.IsPositiveAverageConditional(vdouble11_F);
			// Message to 'vbool1_marginal' from DerivedVariable factor
			this.vbool1_marginal_F = DerivedVariableOp.MarginalAverageConditional<Bernoulli>(vbool1_use_B, vbool1_F, this.vbool1_marginal_F);
			Gaussian vdouble13_F = default(Gaussian);
			this.vdouble13_marginal_F = Gaussian.Uniform();
			Gaussian vdouble13_use_B = Gaussian.Uniform();
			// Message to 'vdouble13' from Difference factor
			vdouble13_F = DoublePlusOp.AAverageConditional(18.0, vdouble7_uses_F[2]);
			// Message to 'vdouble13_marginal' from DerivedVariable factor
			this.vdouble13_marginal_F = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble13_use_B, vdouble13_F, this.vdouble13_marginal_F);
			Bernoulli vbool2_F = default(Bernoulli);
			this.vbool2_marginal_F = Bernoulli.Uniform();
			Bernoulli vbool2_use_B = Bernoulli.Uniform();
			// Message to 'vbool2' from IsPositive factor
			vbool2_F = IsPositiveOp.IsPositiveAverageConditional(vdouble13_F);
			// Message to 'vbool2_marginal' from DerivedVariable factor
			this.vbool2_marginal_F = DerivedVariableOp.MarginalAverageConditional<Bernoulli>(vbool2_use_B, vbool2_F, this.vbool2_marginal_F);
			this.Changed_vGamma1_vGaussian1_isDone = true;
		}

		/// <summary>Computations that depend on the observed value of vGaussian1</summary>
		private void Changed_vGaussian1()
		{
			if (this.Changed_vGaussian1_isDone) {
				return ;
			}
			this.vdouble5_marginal_F = Gaussian.Uniform();
			Gaussian vdouble5_use_B = Gaussian.Uniform();
			// Message to 'vdouble5_marginal' from Variable factor
			this.vdouble5_marginal_F = VariableOp.MarginalAverageConditional<Gaussian>(vdouble5_use_B, this.VGaussian1, this.vdouble5_marginal_F);
			this.vGaussian1_marginal_F = new PointMass<Gaussian>(this.VGaussian1);
			// Message to 'vGaussian1_marginal' from DerivedVariable factor
			this.vGaussian1_marginal_F = DerivedVariableOp.MarginalAverageConditional<PointMass<Gaussian>,Gaussian>(this.VGaussian1, this.vGaussian1_marginal_F);
			this.Changed_vGaussian1_isDone = true;
		}

		/// <summary>Update all marginals, by iterating message passing the given number of times</summary>
		/// <param name="numberOfIterations">The number of times to iterate each loop</param>
		/// <param name="initialise">If true, messages that initialise loops are reset when observed values change</param>
		private void Execute(int numberOfIterations, bool initialise)
		{
			this.Changed_vGamma1();
			this.Changed_vGamma1_vGaussian1();
			this.Changed_vGaussian1();
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
			if (variableName=="vGaussian1") {
				return this.vGaussian1;
			}
			if (variableName=="vGamma1") {
				return this.vGamma1;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Get the marginal distribution (computed up to this point) of a variable</summary>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <returns>The marginal distribution computed up to this point</returns>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public object Marginal(string variableName)
		{
			if (variableName=="vGamma1") {
				return this.VGamma1Marginal();
			}
			if (variableName=="vdouble6") {
				return this.Vdouble6Marginal();
			}
			if (variableName=="vdouble7") {
				return this.Vdouble7Marginal();
			}
			if (variableName=="vdouble9") {
				return this.Vdouble9Marginal();
			}
			if (variableName=="vbool0") {
				return this.Vbool0Marginal();
			}
			if (variableName=="vdouble11") {
				return this.Vdouble11Marginal();
			}
			if (variableName=="vbool1") {
				return this.Vbool1Marginal();
			}
			if (variableName=="vdouble13") {
				return this.Vdouble13Marginal();
			}
			if (variableName=="vbool2") {
				return this.Vbool2Marginal();
			}
			if (variableName=="vGaussian1") {
				return this.VGaussian1Marginal();
			}
			if (variableName=="vdouble5") {
				return this.Vdouble5Marginal();
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
			if (variableName=="vGaussian1") {
				this.vGaussian1 = (Gaussian)value;
				return ;
			}
			if (variableName=="vGamma1") {
				this.vGamma1 = (Gamma)value;
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
		/// Returns the marginal distribution for 'vbool0' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Bernoulli Vbool0Marginal()
		{
			return this.vbool0_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vbool1' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Bernoulli Vbool1Marginal()
		{
			return this.vbool1_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vbool2' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Bernoulli Vbool2Marginal()
		{
			return this.vbool2_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble11' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Gaussian Vdouble11Marginal()
		{
			return this.vdouble11_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble13' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Gaussian Vdouble13Marginal()
		{
			return this.vdouble13_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble5' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Gaussian Vdouble5Marginal()
		{
			return this.vdouble5_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble6' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Gamma Vdouble6Marginal()
		{
			return this.vdouble6_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble7' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Gaussian Vdouble7Marginal()
		{
			return this.vdouble7_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble9' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Gaussian Vdouble9Marginal()
		{
			return this.vdouble9_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vGamma1' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Gamma> VGamma1Marginal()
		{
			return this.vGamma1_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vGaussian1' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Gaussian> VGaussian1Marginal()
		{
			return this.vGaussian1_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}