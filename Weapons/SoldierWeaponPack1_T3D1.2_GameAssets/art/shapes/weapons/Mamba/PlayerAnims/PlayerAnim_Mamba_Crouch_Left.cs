singleton TSShapeConstructor(PlayerAnim_Mamba_Crouch_LeftDAE)
{
   baseShape = "./PlayerAnim_Mamba_Crouch_Left.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_Crouch_LeftDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Left", "520", "549");
}
